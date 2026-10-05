#!/bin/sh
set -e

# Fix permissions at runtime (important for Windows volume mounts)
if [ -d /var/www/html/storage ]; then
    chmod -R 777 /var/www/html/storage
fi

if [ -d /var/www/html/bootstrap/cache ]; then
    chmod -R 777 /var/www/html/bootstrap/cache
fi

# Execute the main command
exec "$@"
