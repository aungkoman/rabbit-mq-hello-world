# Laravel Docker Project

A production-ready Laravel application running completely inside Docker with PHP-FPM, Nginx, MySQL, Redis, and Node.js/Vite.

## Requirements

- Docker
- Docker Compose

No PHP, Composer, Node.js, npm, or MySQL installation required on the host machine.

## Installation

1. Clone the repository:
```bash
git clone <repository-url>
cd laravel-docker
```

2. Copy environment file:
```bash
cp .env.example .env
```

3. Build Docker images:
```bash
docker compose build
```

4. Start containers:
```bash
docker compose up -d
```

5. Generate Laravel application key:
```bash
docker compose exec app php artisan key:generate
```

6. Run database migrations:
```bash
docker compose exec app php artisan migrate
```

7. Install npm dependencies:
```bash
docker compose exec node npm install
```

The application will be available at: http://localhost:8000

## Docker Services

This project includes the following Docker services:

- **app**: PHP 8.3-FPM with Laravel application
- **nginx**: Nginx web server (port 8000)
- **mysql**: MySQL 8.0 database
- **redis**: Redis cache and queue backend
- **node**: Node.js 22 for Vite development (port 5173)
- **queue**: Laravel queue worker
- **scheduler**: Laravel task scheduler

## Useful Commands

### Container Management

Start all containers:
```bash
docker compose up -d
```

Stop all containers:
```bash
docker compose down
```

View container status:
```bash
docker compose ps
```

View logs:
```bash
docker compose logs -f
```

View logs for a specific service:
```bash
docker compose logs -f app
docker compose logs -f nginx
docker compose logs -f mysql
```

Rebuild containers:
```bash
docker compose build
docker compose up -d
```

### Laravel / PHP

Enter the PHP container:
```bash
docker compose exec app sh
```

Run Artisan commands:
```bash
docker compose exec app php artisan migrate
docker compose exec app php artisan migrate:rollback
docker compose exec app php artisan tinker
docker compose exec app php artisan queue:work
docker compose exec app php artisan schedule:work



docker compose exec app php artisan make:controller TestController
docker compose exec app php artisan make:controller TestController
```

Composer commands:
```bash
docker compose exec app composer install
docker compose exec app composer update
docker compose exec app composer require package/name

docker compose exec app composer require laravel/telescope
 docker compose exec app composer require laravel/telescope:*
docker compose exec app php artisan telescope:install
docker compose exec app php artisan migrate

```

### Node.js / Vite

Install npm dependencies:
```bash
docker compose exec node npm install
```

Run Vite development server:
```bash
docker compose exec node npm run dev
```

Build assets for production:
```bash
docker compose exec node npm run build
```

Add npm package:
```bash
docker compose exec node npm install package-name
```

### Database

Access MySQL:
```bash
docker compose exec mysql mysql -u laravel -psecret laravel
```

Reset database:
```bash
docker compose exec app php artisan migrate:fresh
```

Seed database:
```bash
docker compose exec app php artisan db:seed
```

### Testing

Run PHPUnit tests:
```bash
docker compose exec app php artisan test
```

Run specific test:
```bash
docker compose exec app php artisan test --filter BasicTest
```

### Queue Worker

The queue worker runs automatically and processes jobs from Redis. To manually run the queue worker:
```bash
docker compose exec app php artisan queue:work redis
```

### Scheduler

The scheduler runs automatically and executes Laravel's scheduled tasks. To manually run the scheduler:
```bash
docker compose exec app php artisan schedule:work
```

## Project Structure

```
laravel-docker/
├── app/                    # Application code
├── bootstrap/              # Bootstrap files
├── config/                 # Configuration files
├── database/               # Database migrations and seeders
├── docker/                 # Docker configuration
│   ├── nginx/
│   │   └── default.conf    # Nginx configuration
│   └── php/
│       ├── Dockerfile      # PHP-FPM Dockerfile
│       └── local.ini       # PHP configuration
├── public/                 # Public files
├── resources/              # Views, CSS, JS
├── routes/                 # Route definitions
├── storage/                # Generated files
├── tests/                  # Test files
├── docker-compose.yml      # Docker Compose configuration
├── .env.example            # Environment variables template
├── .dockerignore           # Docker ignore file
├── composer.json           # PHP dependencies
├── package.json            # Node.js dependencies
└── vite.config.js          # Vite configuration
```

## Configuration

### Environment Variables

Key environment variables in `.env`:

- `APP_NAME`: Application name
- `APP_ENV`: Environment (local, production)
- `APP_DEBUG`: Enable/disable debug mode
- `APP_URL`: Application URL
- `DB_HOST`: MySQL host (mysql)
- `DB_DATABASE`: Database name (laravel)
- `DB_USERNAME`: Database username (laravel)
- `DB_PASSWORD`: Database password (secret)
- `REDIS_HOST`: Redis host (redis)
- `CACHE_DRIVER`: Cache driver (redis)
- `QUEUE_CONNECTION`: Queue connection (redis)
- `SESSION_DRIVER`: Session driver (redis)

### Vite Configuration

Vite is configured to run on `0.0.0.0:5173` to allow hot module replacement from the host browser. The configuration is in `vite.config.js`.

## Troubleshooting

### MySQL Connection Refused

If you see "Connection refused" errors:
1. Ensure MySQL container is running: `docker compose ps`
2. Check MySQL logs: `docker compose logs mysql`
3. Wait for MySQL to be healthy (healthcheck runs every 10s)
4. Verify DB_HOST is set to `mysql` (not localhost) in `.env`

### Permission Denied

If you encounter permission issues with storage:
```bash
docker compose exec app chown -R www:www storage bootstrap/cache
docker compose exec app chmod -R 775 storage bootstrap/cache
```

### Port 8000 Already in Use

If port 8000 is already in use on your host machine, edit `docker-compose.yml` and change the nginx port mapping:
```yaml
ports:
  - "8080:80"  # Change 8000 to 8080
```

Then update `APP_URL` in `.env` accordingly.

### Vite Not Loading

If Vite hot module replacement is not working:
1. Ensure the node container is running: `docker compose ps`
2. Check node logs: `docker compose logs node`
3. Verify VITE_PORT in your browser's console
4. Restart the node container: `docker compose restart node`

### Composer Dependency Problems

If Composer fails to install dependencies:
```bash
docker compose exec app composer install --no-scripts
docker compose exec app composer dump-autoload
```

### Stale Docker Volumes

If you need to completely reset the project:
```bash
docker compose down -v
docker compose build --no-cache
docker compose up -d
```

This will remove all volumes (including database data).

### Laravel APP_KEY Missing

If you see "No application encryption key has been specified":
```bash
docker compose exec app php artisan key:generate
```

### Queue Worker Not Processing Jobs

Check queue worker logs:
```bash
docker compose logs queue
```

Restart the queue worker:
```bash
docker compose restart queue
```

### Scheduler Not Running

Check scheduler logs:
```bash
docker compose logs scheduler
```

Restart the scheduler:
```bash
docker compose restart scheduler
```

## Security Notes

- Never commit `.env` to version control
- Change default database passwords in production
- Set `APP_DEBUG=false` in production
- Only expose necessary ports
- Use HTTPS in production
- Keep Docker images updated
- Use non-root users in containers (implemented)

## Development Workflow

1. Make code changes in your local files
2. Changes are reflected immediately due to volume mounts
3. Vite hot module replacement updates CSS/JS automatically
4. PHP changes require no rebuild
5. For changes requiring Composer: `docker compose exec app composer install`
6. For changes requiring npm: `docker compose exec node npm install`

## Testing

Run the test suite:
```bash
docker compose exec app php artisan test
```

The project includes basic tests for:
- Homepage returns HTTP 200
- Database connectivity

## Production Deployment

For production deployment:

1. Set `APP_ENV=production` and `APP_DEBUG=false` in `.env`
2. Build production assets: `docker compose exec node npm run build`
3. Use environment variables for secrets (not `.env`)
4. Use HTTPS with a reverse proxy
5. Configure proper backup strategy for MySQL volume
6. Set up monitoring and logging
7. Use proper SSL certificates
8. Configure firewall rules

## License

MIT License
