```bash
PS D:\Cisco\Code\RabbitMQ> docker compose up --build  
time="2026-09-28T10:19:23+06:30" level=warning msg="D:\\Cisco\\Code\\RabbitMQ\\docker-compose.yml: the attribute `version` is obsolete, it will be ignored, please remove it to avoid potential confusion"
[+] Building 4.0s (35/35) FINISHED                                                                                                                                                                                                              
 => [internal] load local bake definitions                                                                                                                                                                                                 0.0s
 => => reading from stdin 1.96kB                                                                                                                                                                                                           0.0s
 => [service-2 internal] load build definition from Dockerfile                                                                                                                                                                             0.0s
 => => transferring dockerfile: 186B                                                                                                                                                                                                       0.0s
 => [service-1 internal] load build definition from Dockerfile                                                                                                                                                                             0.1s
 => => transferring dockerfile: 186B                                                                                                                                                                                                       0.0s
 => [service-3 internal] load build definition from Dockerfile                                                                                                                                                                             0.0s
 => => transferring dockerfile: 186B                                                                                                                                                                                                       0.0s
 => [service-4 internal] load build definition from Dockerfile                                                                                                                                                                             0.1s
 => => transferring dockerfile: 335B                                                                                                                                                                                                       0.0s
 => [service-1 internal] load metadata for docker.io/library/node:18-alpine                                                                                                                                                                2.2s
 => [service-4 internal] load metadata for mcr.microsoft.com/dotnet/sdk:10.0                                                                                                                                                              64.1s
 => [service-4 internal] load .dockerignore                                                                                                                                                                                                0.0s
 => => transferring context: 56B                                                                                                                                                                                                           0.0s
 => CACHED [service-4 1/2] FROM mcr.microsoft.com/dotnet/sdk:10.0@sha256:35d40304542c8689331f8cab17c65926cdf48fe711e289321d71924b230a7d29                                                                                                  0.0s
 => => resolve mcr.microsoft.com/dotnet/sdk:10.0@sha256:35d40304542c8689331f8cab17c65926cdf48fe711e289321d71924b230a7d29                                                                                                                   0.0s
 => [service-4 2/2] WORKDIR /app                                                                                                                                                                                                           0.0s
 => [service-4] exporting to image                                                                                                                                                                                                         0.4s
 => => exporting layers                                                                                                                                                                                                                    0.1s
 => => exporting manifest sha256:3535f039447433be8919b2af9b80794a85012999f64724e86925576ecc90e293                                                                                                                                          0.0s
 => => exporting config sha256:5fdc47e7a6f3a5d2c870592948a9aab31b625fe53707c15f47307a504dbd4faa                                                                                                                                            0.0s
 => => exporting attestation manifest sha256:bf44d9df6976b43d563cd24a3c69a05bdbe2657f59d66d3b50c92599fb770c4f                                                                                                                              0.1s
 => => exporting manifest list sha256:42ff8d0ee858dc9fbb3b7fa5688daef90b80d9911abad58e89ed202f88277285                                                                                                                                     0.0s
 => => naming to docker.io/library/rabbitmq-service-4:latest                                                                                                                                                                               0.0s
 => => unpacking to docker.io/library/rabbitmq-service-4:latest                                                                                                                                                                            0.0s
 => [service-4] resolving provenance for metadata file                                                                                                                                                                                     0.0s
 => [service-2 internal] load .dockerignore                                                                                                                                                                                                0.1s
 => => transferring context: 2B                                                                                                                                                                                                            0.0s
 => [service-3 internal] load .dockerignore                                                                                                                                                                                                0.0s
 => => transferring context: 2B                                                                                                                                                                                                            0.0s
 => [service-1 internal] load .dockerignore                                                                                                                                                                                                0.0s
 => => transferring context: 2B                                                                                                                                                                                                            0.0s
 => [service-3 1/5] FROM docker.io/library/node:18-alpine@sha256:8d6421d663b4c28fd3ebc498332f249011d118945588d0a35cb9bc4b8ca09d9e                                                                                                          0.0s
 => => resolve docker.io/library/node:18-alpine@sha256:8d6421d663b4c28fd3ebc498332f249011d118945588d0a35cb9bc4b8ca09d9e                                                                                                                    0.0s
 => [service-3 internal] load build context                                                                                                                                                                                                0.0s
 => => transferring context: 124B                                                                                                                                                                                                          0.0s
 => [service-2 internal] load build context                                                                                                                                                                                                0.0s
 => => transferring context: 124B                                                                                                                                                                                                          0.0s
 => [service-1 internal] load build context                                                                                                                                                                                                0.0s
 => => transferring context: 124B                                                                                                                                                                                                          0.0s
 => CACHED [service-1 2/5] WORKDIR /app                                                                                                                                                                                                    0.0s
 => CACHED [service-3 3/5] COPY package*.json ./                                                                                                                                                                                           0.0s
 => CACHED [service-3 4/5] RUN npm install                                                                                                                                                                                                 0.0s
 => CACHED [service-3 5/5] COPY . .                                                                                                                                                                                                        0.0s
 => CACHED [service-2 3/5] COPY package*.json ./                                                                                                                                                                                           0.0s
 => CACHED [service-2 4/5] RUN npm install                                                                                                                                                                                                 0.0s
 => CACHED [service-2 5/5] COPY . .                                                                                                                                                                                                        0.0s
 => CACHED [service-1 3/5] COPY package*.json ./                                                                                                                                                                                           0.0s
 => CACHED [service-1 4/5] RUN npm install                                                                                                                                                                                                 0.0s
 => CACHED [service-1 5/5] COPY . .                                                                                                                                                                                                        0.0s
 => [service-2] exporting to image                                                                                                                                                                                                         0.4s
 => => exporting layers                                                                                                                                                                                                                    0.0s
 => => exporting manifest sha256:d83e1267b4a7c5559167543fb736ab05f70be0de75db605a3fc951db39a313ee                                                                                                                                          0.0s
 => => exporting config sha256:12b1aa716c3519e1fbc409cb0a8fa147f12d68b9e79dd4356d5798043e8cf6b2                                                                                                                                            0.0s
 => => exporting attestation manifest sha256:0498c19dcc5139ffc6393c56b09787c754ecee21d251241de9b559206ee92d25                                                                                                                              0.1s
 => => exporting manifest list sha256:5898007020c17e2c2ea4794d6f8ecb0163d47f34d9d4ab485711cac7c54f5c62                                                                                                                                     0.1s
 => => naming to docker.io/library/rabbitmq-service-2:latest                                                                                                                                                                               0.0s
 => => unpacking to docker.io/library/rabbitmq-service-2:latest                                                                                                                                                                            0.0s
 => [service-3] exporting to image                                                                                                                                                                                                         0.4s
 => => exporting layers                                                                                                                                                                                                                    0.0s
 => => exporting manifest sha256:97195a9c756d1022994597f76f6c286efcb5fa6307415b3c06f0ebd95d002390                                                                                                                                          0.0s
 => => exporting config sha256:9654704a829fd602fe0878d94679b02bac7edc56f083b30b1e12d2210bcd9815                                                                                                                                            0.0s
 => => exporting attestation manifest sha256:dc78f5d7c09a1be2b8cb36cf2e9f7326dc99385ee2ef262ff9fa818fdd5438dd                                                                                                                              0.1s
 => => exporting manifest list sha256:e97f51e605783d44e6854dd447ce00d3e233f175829f9e5f959568bd1ebe28f4                                                                                                                                     0.1s
 => => naming to docker.io/library/rabbitmq-service-3:latest                                                                                                                                                                               0.0s
 => => unpacking to docker.io/library/rabbitmq-service-3:latest                                                                                                                                                                            0.0s
 => [service-1] exporting to image                                                                                                                                                                                                         0.4s
 => => exporting layers                                                                                                                                                                                                                    0.0s
 => => exporting manifest sha256:b18d2323484aad9a0815fbeb8980482dcbff74d0b82a5256fae52f0c2aa4ab7e                                                                                                                                          0.0s
 => => exporting config sha256:cc8a49c5fbc7f6cdb11ef4273404cafa03c108e1ae2f8c4f53388f57b3eb619c                                                                                                                                            0.0s
 => => exporting attestation manifest sha256:43bbc94740ad7270a664ae040aa6c2af7c0304731609a9950cd4bc8a25717b3f                                                                                                                              0.1s
 => => exporting manifest list sha256:5626d62f3c8cb75f7eecb3ea90ae5fdd0a7c154fc2cc6b3624f5f57d6ddf71e6                                                                                                                                     0.1s
 => => naming to docker.io/library/rabbitmq-service-1:latest                                                                                                                                                                               0.0s
 => => unpacking to docker.io/library/rabbitmq-service-1:latest                                                                                                                                                                            0.0s
 => [service-2] resolving provenance for metadata file                                                                                                                                                                                     0.1s
 => [service-3] resolving provenance for metadata file                                                                                                                                                                                     0.1s
 => [service-1] resolving provenance for metadata file                                                                                                                                                                                     0.0s
[+] Running 10/10
 ✔ rabbitmq-service-2           Built                                                                                                                                                                                                      0.0s 
 ✔ rabbitmq-service-3           Built                                                                                                                                                                                                      0.0s 
 ✔ rabbitmq-service-4           Built                                                                                                                                                                                                      0.0s 
 ✔ rabbitmq-service-1           Built                                                                                                                                                                                                      0.0s 
 ✔ Network rabbitmq_default     Created                                                                                                                                                                                                    0.1s 
 ✔ Container service-4-dotnet   Created                                                                                                                                                                                                    0.1s 
 ✔ Container rabbitmq-server    Created                                                                                                                                                                                                    0.2s 
 ✔ Container service-1-express  Created                                                                                                                                                                                                    0.8s 
 ✔ Container service-3-express  Created                                                                                                                                                                                                    0.8s 
 ✔ Container service-2-hono     Created                                                                                                                                                                                                    1.0s 
Attaching to rabbitmq-server, service-1-express, service-2-hono, service-3-express, service-4-dotnet
service-4-dotnet  | dotnet watch ⌚ Polling file watcher is enabled
service-4-dotnet  | dotnet watch 🔥 Hot reload enabled. For a list of supported edits, see https://aka.ms/dotnet/hot-reload.
service-4-dotnet  | dotnet watch 💡 Press Ctrl+R to restart.
service-2-hono    | 
service-2-hono    | > dev

service-3-express  | 
service-2-hono     | > npx nodemon -L index.js
service-2-hono     | 
service-3-express  | > dev
service-3-express  | > npx nodemon -L index.js
service-3-express  | 
service-1-express  | 
service-1-express  | > dev
service-1-express  | > npx nodemon -L index.js
service-1-express  | 
service-1-express  | npm warn exec The following package was not found and will be installed: nodemon@3.1.14
service-2-hono     | npm warn exec The following package was not found and will be installed: nodemon@3.1.14
service-3-express  | npm warn exec The following package was not found and will be installed: nodemon@3.1.14
service-4-dotnet   |   Determining projects to restore...
service-1-express  | npm warn EBADENGINE Unsupported engine {
service-1-express  | npm warn EBADENGINE   package: 'brace-expansion@5.0.12',
service-1-express  | npm warn EBADENGINE   required: { node: '20 || >=22' },
service-1-express  | npm warn EBADENGINE   current: { node: 'v18.20.8', npm: '10.8.2' }
service-1-express  | npm warn EBADENGINE }

service-2-hono     | npm warn EBADENGINE Unsupported engine {
service-2-hono     | npm warn EBADENGINE   package: 'brace-expansion@5.0.12',
service-2-hono     | npm warn EBADENGINE   required: { node: '20 || >=22' },
service-2-hono     | npm warn EBADENGINE   current: { node: 'v18.20.8', npm: '10.8.2' }


service-3-express  | npm warn EBADENGINE Unsupported engine {
service-2-hono     | npm warn EBADENGINE }
service-3-express  | npm warn EBADENGINE   package: 'brace-expansion@5.0.12',
service-3-express  | npm warn EBADENGINE   required: { node: '20 || >=22' },
service-3-express  | npm warn EBADENGINE   current: { node: 'v18.20.8', npm: '10.8.2' }
service-3-express  | npm warn EBADENGINE }
service-1-express  | [nodemon] 3.1.14
service-1-express  | [nodemon] to restart at any time, enter `rs`
service-1-express  | [nodemon] watching path(s): *.*
service-1-express  | [nodemon] watching extensions: js,mjs,cjs,json
service-1-express  | [nodemon] starting `node index.js`
service-2-hono     | [nodemon] 3.1.14
service-2-hono     | [nodemon] to restart at any time, enter `rs`
service-2-hono     | [nodemon] watching path(s): *.*
service-2-hono     | [nodemon] watching extensions: js,mjs,cjs,json
service-2-hono     | [nodemon] starting `node index.js`
service-3-express  | [nodemon] 3.1.14
service-3-express  | [nodemon] to restart at any time, enter `rs`
service-3-express  | [nodemon] watching path(s): *.*
service-3-express  | [nodemon] watching extensions: js,mjs,cjs,json
service-3-express  | [nodemon] starting `node index.js`
service-2-hono     | Service 2 running on port 3002


service-2-hono     | Service 2: Waiting for RabbitMQ...ort 3001
service-1-express  | Service 1: Waiting for RabbitMQ...
service-3-express  | Service 3 running on port 3003
service-3-express  | Service 3: Waiting for RabbitMQ...
rabbitmq-server    | 2026-09-28 03:48:33.353184+00:00 [notice] <0.44.0> Application syslog exited with reason: stopped
rabbitmq-server    | 2026-09-28 03:48:33.360115+00:00 [notice] <0.254.0> Logging: switching to configured handler(s); following messages may not be visible in this log output
rabbitmq-server    | 2026-09-28 03:48:33.360844+00:00 [notice] <0.254.0> Logging: configured log handlers are now ACTIVE
rabbitmq-server    | 2026-09-28 03:48:33.379196+00:00 [info] <0.254.0> ra: starting system quorum_queues
rabbitmq-server    | 2026-09-28 03:48:33.379318+00:00 [info] <0.254.0> starting Ra system: quorum_queues in directory: /var/lib/rabbitmq/mnesia/rabbit@9c069fdedc87/quorum/rabbit@9c069fdedc87
rabbitmq-server    | 2026-09-28 03:48:33.513990+00:00 [info] <0.268.0> ra system 'quorum_queues' running pre init for 0 registered servers
rabbitmq-server    | 2026-09-28 03:48:33.542157+00:00 [info] <0.269.0> ra: meta data store initialised for system quorum_queues. 0 record(s) recovered
rabbitmq-server    | 2026-09-28 03:48:33.609776+00:00 [notice] <0.274.0> WAL: ra_log_wal init, open tbls: ra_log_open_mem_tables, closed tbls: ra_log_closed_mem_tables
rabbitmq-server    | 2026-09-28 03:48:33.686981+00:00 [info] <0.254.0> ra: starting system coordination
rabbitmq-server    | 2026-09-28 03:48:33.687066+00:00 [info] <0.254.0> starting Ra system: coordination in directory: /var/lib/rabbitmq/mnesia/rabbit@9c069fdedc87/coordination/rabbit@9c069fdedc87
rabbitmq-server    | 2026-09-28 03:48:33.691178+00:00 [info] <0.282.0> ra system 'coordination' running pre init for 0 registered servers
rabbitmq-server    | 2026-09-28 03:48:33.698287+00:00 [info] <0.283.0> ra: meta data store initialised for system coordination. 0 record(s) recovered
rabbitmq-server    | 2026-09-28 03:48:33.699281+00:00 [notice] <0.288.0> WAL: ra_coordination_log_wal init, open tbls: ra_coordination_log_open_mem_tables, closed tbls: ra_coordination_log_closed_mem_tables
rabbitmq-server    | 2026-09-28 03:48:33.713725+00:00 [info] <0.254.0> ra: starting system coordination
rabbitmq-server    | 2026-09-28 03:48:33.713799+00:00 [info] <0.254.0> starting Ra system: coordination in directory: /var/lib/rabbitmq/mnesia/rabbit@9c069fdedc87/coordination/rabbit@9c069fdedc87
rabbitmq-server    | 2026-09-28 03:48:34.063175+00:00 [info] <0.254.0> Waiting for Khepri leader for 30000 ms, 9 retries left
rabbitmq-server    | 2026-09-28 03:48:34.106804+00:00 [notice] <0.292.0> RabbitMQ metadata store: candidate -> leader in term: 1 machine version: 1
rabbitmq-server    | 2026-09-28 03:48:34.123891+00:00 [info] <0.254.0> Khepri leader elected
rabbitmq-server    | 2026-09-28 03:48:34.123998+00:00 [info] <0.254.0> Waiting for Khepri projections for 30000 ms, 9 retries left
rabbitmq-server    | 2026-09-28 03:48:34.645093+00:00 [info] <0.254.0> 
rabbitmq-server    | 2026-09-28 03:48:34.645093+00:00 [info] <0.254.0>  Starting RabbitMQ 3.13.7 on Erlang 26.2.5.16 [jit]
rabbitmq-server    | 2026-09-28 03:48:34.645093+00:00 [info] <0.254.0>  Copyright (c) 2007-2024 Broadcom Inc and/or its subsidiaries
rabbitmq-server    | 2026-09-28 03:48:34.645093+00:00 [info] <0.254.0>  Licensed under the MPL 2.0. Website: https://rabbitmq.com
rabbitmq-server    | 
rabbitmq-server    |   ##  ##      RabbitMQ 3.13.7
rabbitmq-server    |   ##  ##
rabbitmq-server    |   ##########  Copyright (c) 2007-2024 Broadcom Inc and/or its subsidiaries
rabbitmq-server    |   ######  ##


rabbitmq-server    |   ##########  Licensed under the MPL 2.0. Website: https://rabbitmq.com
service-1-express  | Service 1: Waiting for RabbitMQ...
rabbitmq-server    | 
rabbitmq-server    |   Erlang:      26.2.5.16 [jit]
rabbitmq-server    |   TLS Library: OpenSSL - OpenSSL 3.1.8 11 Feb 2025
rabbitmq-server    |   Release series support status: see https://www.rabbitmq.com/release-information
rabbitmq-server    | 
rabbitmq-server    |   Doc guides:  https://www.rabbitmq.com/docs
rabbitmq-server    |   Support:     https://www.rabbitmq.com/docs/contact
rabbitmq-server    |   Tutorials:   https://www.rabbitmq.com/tutorials
rabbitmq-server    |   Monitoring:  https://www.rabbitmq.com/docs/monitoring
rabbitmq-server    |   Upgrading:   https://www.rabbitmq.com/docs/upgrade
rabbitmq-server    | 
rabbitmq-server    |   Logs: <stdout>
rabbitmq-server    | 
rabbitmq-server    |   Config file(s): /etc/rabbitmq/conf.d/10-defaults.conf
rabbitmq-server    | 
rabbitmq-server    |   Starting broker...2026-09-28 03:48:34.646891+00:00 [info] <0.254.0> 
rabbitmq-server    | 2026-09-28 03:48:34.646891+00:00 [info] <0.254.0>  node           : rabbit@9c069fdedc87
rabbitmq-server    | 2026-09-28 03:48:34.646891+00:00 [info] <0.254.0>  home dir       : /var/lib/rabbitmq
rabbitmq-server    | 2026-09-28 03:48:34.646891+00:00 [info] <0.254.0>  config file(s) : /etc/rabbitmq/conf.d/10-defaults.conf
rabbitmq-server    | 2026-09-28 03:48:34.646891+00:00 [info] <0.254.0>  cookie hash    : /OuM01lQ0zduP6FDaSSFcg==
rabbitmq-server    | 2026-09-28 03:48:34.646891+00:00 [info] <0.254.0>  log(s)         : <stdout>
rabbitmq-server    | 2026-09-28 03:48:34.646891+00:00 [info] <0.254.0>  data dir       : /var/lib/rabbitmq/mnesia/rabbit@9c069fdedc87
service-3-express  | Service 3: Waiting for RabbitMQ...
rabbitmq-server    | 2026-09-28 03:48:35.835420+00:00 [info] <0.254.0> Running boot step pre_boot defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:35.835899+00:00 [info] <0.254.0> Running boot step rabbit_global_counters defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:35.836820+00:00 [info] <0.254.0> Running boot step rabbit_osiris_metrics defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:35.837008+00:00 [info] <0.254.0> Running boot step rabbit_core_metrics defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:35.837906+00:00 [info] <0.254.0> Running boot step rabbit_alarm defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:35.876632+00:00 [info] <0.329.0> Memory high watermark set to 3144 MiB (3297612595 bytes) of 7862 MiB (8244031488 bytes) total
rabbitmq-server    | 2026-09-28 03:48:35.910348+00:00 [info] <0.331.0> Enabling free disk space monitoring (disk free space: 1018949931008, total memory: 8244031488)
rabbitmq-server    | 2026-09-28 03:48:35.910523+00:00 [info] <0.331.0> Disk free limit set to 50MB
rabbitmq-server    | 2026-09-28 03:48:35.917976+00:00 [info] <0.254.0> Running boot step code_server_cache defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:35.918497+00:00 [info] <0.254.0> Running boot step file_handle_cache defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:35.938318+00:00 [info] <0.334.0> Limiting to approx 1048479 file handles (943629 sockets)
rabbitmq-server    | 2026-09-28 03:48:35.938593+00:00 [info] <0.335.0> FHC read buffering: OFF
rabbitmq-server    | 2026-09-28 03:48:35.938655+00:00 [info] <0.335.0> FHC write buffering: ON
rabbitmq-server    | 2026-09-28 03:48:35.939362+00:00 [info] <0.254.0> Running boot step worker_pool defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:35.939577+00:00 [info] <0.315.0> Will use 6 processes for default worker pool
rabbitmq-server    | 2026-09-28 03:48:35.939631+00:00 [info] <0.315.0> Starting worker pool 'worker_pool' with 6 processes in it
rabbitmq-server    | 2026-09-28 03:48:35.940060+00:00 [info] <0.254.0> Running boot step database defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:35.940539+00:00 [info] <0.254.0> Peer discovery: configured backend: rabbit_peer_discovery_classic_config
rabbitmq-server    | 2026-09-28 03:48:35.941883+00:00 [notice] <0.316.0> Feature flags: attempt to enable `detailed_queues_endpoint`...
rabbitmq-server    | 2026-09-28 03:48:36.098835+00:00 [notice] <0.316.0> Feature flags: `detailed_queues_endpoint` enabled
rabbitmq-server    | 2026-09-28 03:48:36.099057+00:00 [notice] <0.316.0> Feature flags: attempt to enable `quorum_queue_non_voters`...
rabbitmq-server    | 2026-09-28 03:48:36.198637+00:00 [notice] <0.316.0> Feature flags: `quorum_queue_non_voters` enabled
rabbitmq-server    | 2026-09-28 03:48:36.198865+00:00 [notice] <0.316.0> Feature flags: attempt to enable `stream_update_config_command`...
rabbitmq-server    | 2026-09-28 03:49:39.962953+00:00 [notice] <0.316.0> Feature flags: `stream_update_config_command` enabled
rabbitmq-server    | 2026-09-28 03:49:39.963075+00:00 [notice] <0.316.0> Feature flags: attempt to enable `stream_filtering`...
rabbitmq-server    | 2026-09-28 03:49:40.051977+00:00 [notice] <0.316.0> Feature flags: `stream_filtering` enabled
rabbitmq-server    | 2026-09-28 03:49:40.052107+00:00 [notice] <0.316.0> Feature flags: attempt to enable `stream_sac_coordinator_unblock_group`...
rabbitmq-server    | 2026-09-28 03:49:40.135511+00:00 [notice] <0.316.0> Feature flags: `stream_sac_coordinator_unblock_group` enabled
rabbitmq-server    | 2026-09-28 03:49:40.135648+00:00 [notice] <0.316.0> Feature flags: attempt to enable `restart_streams`...
rabbitmq-server    | 2026-09-28 03:48:36.575665+00:00 [notice] <0.316.0> Feature flags: `restart_streams` enabled
rabbitmq-server    | 2026-09-28 03:48:36.575842+00:00 [notice] <0.316.0> Feature flags: attempt to enable `message_containers`...
rabbitmq-server    | 2026-09-28 03:48:36.663143+00:00 [notice] <0.316.0> Feature flags: `message_containers` enabled
rabbitmq-server    | 2026-09-28 03:48:36.663261+00:00 [notice] <0.316.0> Feature flags: attempt to enable `message_containers_deaths_v2`...
rabbitmq-server    | 2026-09-28 03:48:36.738998+00:00 [notice] <0.316.0> Feature flags: `message_containers_deaths_v2` enabled
rabbitmq-server    | 2026-09-28 03:48:36.740214+00:00 [info] <0.254.0> DB: virgin node -> run peer discovery
rabbitmq-server    | 2026-09-28 03:48:36.740304+00:00 [warning] <0.254.0> Classic peer discovery backend: list of nodes does not contain the local node []
rabbitmq-server    | 2026-09-28 03:48:36.753558+00:00 [notice] <0.44.0> Application mnesia exited with reason: stopped
service-1-express  | Service 1: Waiting for RabbitMQ...
service-2-hono     | Service 2: Waiting for RabbitMQ...
rabbitmq-server    | 2026-09-28 03:48:37.027292+00:00 [info] <0.254.0> Waiting for Mnesia tables for 30000 ms, 9 retries left
rabbitmq-server    | 2026-09-28 03:48:37.027436+00:00 [info] <0.254.0> Successfully synced tables from a peer
rabbitmq-server    | 2026-09-28 03:48:37.027660+00:00 [info] <0.254.0> Waiting for Mnesia tables for 30000 ms, 9 retries left
rabbitmq-server    | 2026-09-28 03:48:37.027845+00:00 [info] <0.254.0> Successfully synced tables from a peer
rabbitmq-server    | 2026-09-28 03:48:37.067667+00:00 [info] <0.254.0> Waiting for Mnesia tables for 30000 ms, 9 retries left
rabbitmq-server    | 2026-09-28 03:48:37.067863+00:00 [info] <0.254.0> Successfully synced tables from a peer
rabbitmq-server    | 2026-09-28 03:48:37.068070+00:00 [info] <0.254.0> Running boot step tracking_metadata_store defined by app rabbit
service-3-express  | Service 3: Waiting for RabbitMQ...
rabbitmq-server    | 2026-09-28 03:48:37.068158+00:00 [info] <0.560.0> Setting up a table for connection tracking on this node: tracked_connection

rabbitmq-server    | 2026-09-28 03:48:37.068215+00:00 [info] <0.560.0> Setting up a table for per-vhost connection counting on this node: tracked_connection_per_vhost
rabbitmq-server    | 2026-09-28 03:48:37.068361+00:00 [info] <0.560.0> Setting up a table for per-user connection counting on this node: tracked_connection_per_user

service-1-express  | Service 1: Waiting for RabbitMQ...

service-2-hono     | Service 2: Waiting for RabbitMQ...

rabbitmq-server    | 2026-09-28 03:48:37.068727+00:00 [info] <0.560.0> Setting up a table for channel tracking on this node: tracked_channel
service-3-express  | Service 3: Waiting for RabbitMQ...

rabbitmq-server    | 2026-09-28 03:48:37.071695+00:00 [info] <0.254.0> Running boot step networking_metadata_store defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.072020+00:00 [info] <0.254.0> Running boot step feature_flags defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.072879+00:00 [info] <0.254.0> Running boot step codec_correctness_check defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.073090+00:00 [info] <0.254.0> Running boot step external_infrastructure defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.073228+00:00 [info] <0.254.0> Running boot step rabbit_event defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.073687+00:00 [info] <0.254.0> Running boot step rabbit_registry defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.073939+00:00 [info] <0.254.0> Running boot step rabbit_auth_mechanism_amqplain defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.074175+00:00 [info] <0.254.0> Running boot step rabbit_auth_mechanism_cr_demo defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.075354+00:00 [info] <0.254.0> Running boot step rabbit_auth_mechanism_plain defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.075767+00:00 [info] <0.254.0> Running boot step rabbit_exchange_type_direct defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.076058+00:00 [info] <0.254.0> Running boot step rabbit_exchange_type_fanout defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.076229+00:00 [info] <0.254.0> Running boot step rabbit_exchange_type_headers defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.076419+00:00 [info] <0.254.0> Running boot step rabbit_exchange_type_topic defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.076478+00:00 [info] <0.254.0> Running boot step rabbit_mirror_queue_mode_all defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.076703+00:00 [info] <0.254.0> Running boot step rabbit_mirror_queue_mode_exactly defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.076812+00:00 [info] <0.254.0> Running boot step rabbit_mirror_queue_mode_nodes defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.076858+00:00 [info] <0.254.0> Running boot step rabbit_priority_queue defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.076883+00:00 [info] <0.254.0> Priority queues enabled, real BQ is rabbit_variable_queue
rabbitmq-server    | 2026-09-28 03:48:37.076937+00:00 [info] <0.254.0> Running boot step rabbit_queue_location_client_local defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.076973+00:00 [info] <0.254.0> Running boot step rabbit_queue_location_min_masters defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.077006+00:00 [info] <0.254.0> Running boot step rabbit_queue_location_random defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.077031+00:00 [info] <0.254.0> Running boot step kernel_ready defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.077043+00:00 [info] <0.254.0> Running boot step rabbit_sysmon_minder defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.077172+00:00 [info] <0.254.0> Running boot step rabbit_epmd_monitor defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.079876+00:00 [info] <0.568.0> epmd monitor knows us, inter-node communication (distribution) port: 25672
rabbitmq-server    | 2026-09-28 03:48:37.080763+00:00 [info] <0.254.0> Running boot step guid_generator defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.099054+00:00 [info] <0.254.0> Running boot step rabbit_node_monitor defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.099584+00:00 [info] <0.572.0> Starting rabbit_node_monitor (in ignore mode)
rabbitmq-server    | 2026-09-28 03:48:37.099709+00:00 [info] <0.254.0> Running boot step delegate_sup defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.100067+00:00 [info] <0.254.0> Running boot step rabbit_memory_monitor defined by app rabbit


service-4-dotnet   |   Restored /app/service-4-dotnet.csproj (in 8.94 sec).ing boot step rabbit_fifo_dlx_sup defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.100298+00:00 [info] <0.254.0> Running boot step core_initialized defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.100318+00:00 [info] <0.254.0> Running boot step rabbit_channel_tracking_handler defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.100377+00:00 [info] <0.254.0> Running boot step rabbit_connection_tracking_handler defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.100510+00:00 [info] <0.254.0> Running boot step rabbit_definitions_hashing defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.100617+00:00 [info] <0.254.0> Running boot step rabbit_exchange_parameters defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.228589+00:00 [info] <0.254.0> Running boot step rabbit_mirror_queue_misc defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.229334+00:00 [info] <0.254.0> Running boot step rabbit_policies defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.229626+00:00 [info] <0.254.0> Running boot step rabbit_policy defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.229683+00:00 [info] <0.254.0> Running boot step rabbit_queue_location_validator defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.229759+00:00 [info] <0.254.0> Running boot step rabbit_quorum_memory_manager defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.229881+00:00 [info] <0.254.0> Running boot step rabbit_quorum_queue defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.230007+00:00 [info] <0.254.0> Running boot step rabbit_stream_coordinator defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.230146+00:00 [info] <0.254.0> Running boot step rabbit_vhost_limit defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.230231+00:00 [info] <0.254.0> Running boot step rabbit_federation_parameters defined by app rabbitmq_federation
rabbitmq-server    | 2026-09-28 03:48:37.230476+00:00 [info] <0.254.0> Running boot step rabbit_federation_supervisor defined by app rabbitmq_federation


rabbitmq-server    | 2026-09-28 03:48:37.262554+00:00 [info] <0.254.0> Running boot step rabbit_federation_queue defined by app rabbitmq_federation
rabbitmq-server    | 2026-09-28 03:48:37.262782+00:00 [info] <0.254.0> Running boot step rabbit_federation_upstream_exchange defined by app rabbitmq_federation
rabbitmq-server    | 2026-09-28 03:48:37.262881+00:00 [info] <0.254.0> Running boot step rabbit_mgmt_reset_handler defined by app rabbitmq_management
service-1-express  | Service 1: Waiting for RabbitMQ...info] <0.254.0> Running boot step rabbit_mgmt_db_handler defined by app rabbitmq_management_agent
service-2-hono     | Service 2: Waiting for RabbitMQ...




rabbitmq-server    | 2026-09-28 03:48:37.262989+00:00 [info] <0.254.0> Management plugin: using rates mode 'basic'
service-3-express  | Service 3: Waiting for RabbitMQ...
rabbitmq-server    | 2026-09-28 03:48:37.263425+00:00 [info] <0.254.0> Running boot step recovery defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.418545+00:00 [info] <0.254.0> Running boot step empty_db_check defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.418671+00:00 [info] <0.254.0> Will seed default virtual host and user...
rabbitmq-server    | 2026-09-28 03:48:37.418777+00:00 [info] <0.254.0> Adding vhost '/' (description: 'Default virtual host', tags: [])
rabbitmq-server    | 2026-09-28 03:48:37.551147+00:00 [info] <0.632.0> Making sure data directory '/var/lib/rabbitmq/mnesia/rabbit@9c069fdedc87/msg_stores/vhosts/628WB79CIFDYO9LJI6DKMI09L' for vhost '/' exists
rabbitmq-server    | 2026-09-28 03:48:37.554325+00:00 [info] <0.632.0> Setting segment_entry_count for vhost '/' with 0 queues to '2048'
rabbitmq-server    | 2026-09-28 03:48:37.585357+00:00 [info] <0.632.0> Starting message stores for vhost '/'
rabbitmq-server    | 2026-09-28 03:48:37.585678+00:00 [info] <0.641.0> Message store "628WB79CIFDYO9LJI6DKMI09L/msg_store_transient": using rabbit_msg_store_ets_index to provide index
rabbitmq-server    | 2026-09-28 03:48:37.588350+00:00 [info] <0.632.0> Started message store of type transient for vhost '/'
rabbitmq-server    | 2026-09-28 03:48:37.588678+00:00 [info] <0.645.0> Message store "628WB79CIFDYO9LJI6DKMI09L/msg_store_persistent": using rabbit_msg_store_ets_index to provide index
rabbitmq-server    | 2026-09-28 03:48:37.589935+00:00 [warning] <0.645.0> Message store "628WB79CIFDYO9LJI6DKMI09L/msg_store_persistent": rebuilding indices from scratch
rabbitmq-server    | 2026-09-28 03:48:37.591056+00:00 [info] <0.632.0> Started message store of type persistent for vhost '/'
rabbitmq-server    | 2026-09-28 03:48:37.591298+00:00 [info] <0.632.0> Recovering 0 queues of type rabbit_classic_queue took 36ms
rabbitmq-server    | 2026-09-28 03:48:37.591337+00:00 [info] <0.632.0> Recovering 0 queues of type rabbit_quorum_queue took 0ms
rabbitmq-server    | 2026-09-28 03:48:37.591389+00:00 [info] <0.632.0> Recovering 0 queues of type rabbit_stream_queue took 0ms
rabbitmq-server    | 2026-09-28 03:48:37.623619+00:00 [info] <0.254.0> Created user 'guest'


service-2-hono     | Service 2: Waiting for RabbitMQ...
service-1-express  | Service 1: Waiting for RabbitMQ...
rabbitmq-server    | 2026-09-28 03:48:37.655716+00:00 [info] <0.254.0> Successfully set user tags for user 'guest' to [administrator]
rabbitmq-server    | 2026-09-28 03:48:37.670120+00:00 [info] <0.254.0> Successfully set permissions for user 'guest' in virtual host '/' to '.*', '.*', '.*'
rabbitmq-server    | 2026-09-28 03:48:37.670264+00:00 [info] <0.254.0> Running boot step rabbit_observer_cli defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.670375+00:00 [info] <0.254.0> Running boot step rabbit_looking_glass defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.670423+00:00 [info] <0.254.0> Running boot step rabbit_core_metrics_gc defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.670584+00:00 [info] <0.254.0> Running boot step background_gc defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.670696+00:00 [info] <0.254.0> Running boot step routing_ready defined by app rabbit

rabbitmq-server    | 2026-09-28 03:48:37.670716+00:00 [info] <0.254.0> Running boot step pre_flight defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.670739+00:00 [info] <0.254.0> Running boot step notify_cluster defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.670786+00:00 [info] <0.254.0> Running boot step networking defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.670830+00:00 [info] <0.254.0> Running boot step rabbit_quorum_queue_periodic_membership_reconciliation defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.670925+00:00 [info] <0.254.0> Running boot step definition_import_worker_pool defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.670956+00:00 [info] <0.315.0> Starting worker pool 'definition_import_pool' with 6 processes in it
rabbitmq-server    | 2026-09-28 03:48:37.671213+00:00 [info] <0.254.0> Running boot step cluster_name defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.671274+00:00 [info] <0.254.0> Initialising internal cluster ID to 'rabbitmq-cluster-id-3xtDivrnORy0TAaENmtU3g'
rabbitmq-server    | 2026-09-28 03:48:37.687829+00:00 [info] <0.254.0> Running boot step virtual_host_reconciliation defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.688129+00:00 [info] <0.254.0> Running boot step direct_client defined by app rabbit
rabbitmq-server    | 2026-09-28 03:48:37.688211+00:00 [info] <0.254.0> Running boot step rabbit_federation_exchange defined by app rabbitmq_federation
rabbitmq-server    | 2026-09-28 03:48:37.688331+00:00 [info] <0.254.0> Running boot step rabbit_management_load_definitions defined by app rabbitmq_management
rabbitmq-server    | 2026-09-28 03:48:37.688564+00:00 [info] <0.684.0> Resetting node maintenance status
rabbitmq-server    | 2026-09-28 03:48:38.395362+00:00 [warning] <0.713.0> Deprecated features: `management_metrics_collection`: Feature `management_metrics_collection` is deprecated.
rabbitmq-server    | 2026-09-28 03:48:38.395362+00:00 [warning] <0.713.0> By default, this feature can still be used for now.
rabbitmq-server    | 2026-09-28 03:48:38.395362+00:00 [warning] <0.713.0> Its use will not be permitted by default in a future minor RabbitMQ version and the feature will be removed from a future major RabbitMQ version; actual versions to be determined.
rabbitmq-server    | 2026-09-28 03:48:38.395362+00:00 [warning] <0.713.0> To continue using this feature when it is not permitted by default, set the following parameter in your configuration:
rabbitmq-server    | 2026-09-28 03:48:38.395362+00:00 [warning] <0.713.0>     "deprecated_features.permit.management_metrics_collection = true"
rabbitmq-server    | 2026-09-28 03:48:38.395362+00:00 [warning] <0.713.0> To test RabbitMQ as if the feature was removed, set this in your configuration:
rabbitmq-server    | 2026-09-28 03:48:38.395362+00:00 [warning] <0.713.0>     "deprecated_features.permit.management_metrics_collection = false"
service-1-express  | Service 1: Waiting for RabbitMQ...
service-2-hono     | Service 2: Waiting for RabbitMQ...
service-3-express  | Service 3: Waiting for RabbitMQ...
service-1-express  | Service 1: Waiting for RabbitMQ...
service-2-hono     | Service 2: Waiting for RabbitMQ...
service-3-express  | Service 3: Waiting for RabbitMQ...
rabbitmq-server    | 2026-09-28 03:48:47.268630+00:00 [info] <0.750.0> Management plugin: HTTP (non-TLS) listener started on port 15672
rabbitmq-server    | 2026-09-28 03:48:47.268982+00:00 [info] <0.780.0> Statistics database started.
rabbitmq-server    | 2026-09-28 03:48:47.269096+00:00 [info] <0.779.0> Starting worker pool 'management_worker_pool' with 3 processes in it
rabbitmq-server    | 2026-09-28 03:48:47.291807+00:00 [info] <0.798.0> Prometheus metrics: HTTP (non-TLS) listener started on port 15692
rabbitmq-server    | 2026-09-28 03:48:47.292255+00:00 [info] <0.684.0> Ready to start client connection listeners
rabbitmq-server    | 2026-09-28 03:48:47.345003+00:00 [info] <0.842.0> started TCP listener on [::]:5672
rabbitmq-server    |  completed with 5 plugins.
rabbitmq-server    | 2026-09-28 03:48:47.625817+00:00 [info] <0.684.0> Server startup complete; 5 plugins started.
rabbitmq-server    | 2026-09-28 03:48:47.625817+00:00 [info] <0.684.0>  * rabbitmq_prometheus
rabbitmq-server    | 2026-09-28 03:48:47.625817+00:00 [info] <0.684.0>  * rabbitmq_federation
rabbitmq-server    | 2026-09-28 03:48:47.625817+00:00 [info] <0.684.0>  * rabbitmq_management
rabbitmq-server    | 2026-09-28 03:48:47.625817+00:00 [info] <0.684.0>  * rabbitmq_management_agent
rabbitmq-server    | 2026-09-28 03:48:47.625817+00:00 [info] <0.684.0>  * rabbitmq_web_dispatch
rabbitmq-server    | 2026-09-28 03:48:47.826008+00:00 [info] <0.9.0> Time to start RabbitMQ: 21616 ms


service-3-express  | Service 3 (Express): Connected to RabbitMQ. Waiting for messages...
rabbitmq-server    | 2026-09-28 03:48:48.927050+00:00 [info] <0.847.0> accepting AMQP connection <0.847.0> (172.18.0.6:33688 -> 172.18.0.2:5672)
rabbitmq-server    | 2026-09-28 03:48:48.927088+00:00 [info] <0.850.0> accepting AMQP connection <0.850.0> (172.18.0.4:56954 -> 172.18.0.2:5672)
rabbitmq-server    | 2026-09-28 03:48:48.973193+00:00 [info] <0.847.0> connection <0.847.0> (172.18.0.6:33688 -> 172.18.0.2:5672): user 'guest' authenticated and granted access to vhost '/'
rabbitmq-server    | 2026-09-28 03:48:48.982354+00:00 [warning] <0.863.0> Deprecated features: `transient_nonexcl_queues`: Feature `transient_nonexcl_queues` is deprecated.
rabbitmq-server    | 2026-09-28 03:48:48.982354+00:00 [warning] <0.863.0> By default, this feature can still be used for now.
service-1-express  | Service 1: Connected to RabbitMQ [warning] <0.863.0> Its use will not be permitted by default in a future minor RabbitMQ version and the feature will be removed from a future major RabbitMQ version; actual versions to bservice-2-hono     | Service 2 (Hono): Connected to RabbitMQ. Waiting for messages...
rabbitmq-server    | 2026-09-28 03:48:48.982354+00:00 [warning] <0.863.0> To continue using this feature when it is not permitted by default, set the following parameter in your configuration:


service-2-hono     | Service 2 (Email Worker): Waiting for jobs...
rabbitmq-server    | 2026-09-28 03:48:48.982354+00:00 [warning] <0.863.0> To test RabbitMQ as if the feature was removed, set this in your configuration:
rabbitmq-server    | 2026-09-28 03:48:48.982354+00:00 [warning] <0.863.0>     "deprecated_features.permit.transient_nonexcl_queues = false"
rabbitmq-server    | 2026-09-28 03:48:48.989052+00:00 [info] <0.850.0> connection <0.850.0> (172.18.0.4:56954 -> 172.18.0.2:5672): user 'guest' authenticated and granted access to vhost '/'
rabbitmq-server    | 2026-09-28 03:48:49.162993+00:00 [info] <0.891.0> accepting AMQP connection <0.891.0> (172.18.0.5:45634 -> 172.18.0.2:5672)
rabbitmq-server    | 2026-09-28 03:48:49.220963+00:00 [info] <0.891.0> connection <0.891.0> (172.18.0.5:45634 -> 172.18.0.2:5672): user 'guest' authenticated and granted access to vhost '/'
service-4-dotnet   |   service-4-dotnet -> /app/bin/Debug/net10.0/service-4-dotnet.dll
service-4-dotnet   | 
service-4-dotnet   | Build succeeded.
service-4-dotnet   |     0 Warning(s)
service-4-dotnet   |     0 Error(s)
service-4-dotnet   | 
service-4-dotnet   | Time Elapsed 00:00:08.53
service-4-dotnet   | dotnet watch ⌚ Loading projects ...
service-4-dotnet   | dotnet watch ⌚ Loaded 1 project(s) in 0.7s.
service-4-dotnet   | Using launch settings from /app/Properties/launchSettings.json...
service-4-dotnet   | dotnet watch ⌚ Waiting for changes
rabbitmq-server    | 2026-09-28 03:48:58.198292+00:00 [info] <0.910.0> accepting AMQP connection <0.910.0> (172.18.0.3:44782 -> 172.18.0.2:5672)
rabbitmq-server    | 2026-09-28 03:48:58.225743+00:00 [info] <0.910.0> connection <0.910.0> (172.18.0.3:44782 -> 172.18.0.2:5672): user 'guest' authenticated and granted access to vhost '/'
service-4-dotnet   | warn: Microsoft.AspNetCore.Hosting.Diagnostics[15]
service-4-dotnet   |       Overriding HTTP_PORTS '8080' and HTTPS_PORTS ''. Binding to values defined by URLS instead 'http://0.0.0.0:8080'.
service-4-dotnet   | info: Microsoft.Hosting.Lifetime[14]
service-4-dotnet   |       Now listening on: http://0.0.0.0:8080
service-4-dotnet   | info: Microsoft.Hosting.Lifetime[0]
service-4-dotnet   |       Application started. Press Ctrl+C to shut down.
service-4-dotnet   | info: Microsoft.Hosting.Lifetime[0]
service-4-dotnet   |       Hosting environment: Development
service-4-dotnet   | info: Microsoft.Hosting.Lifetime[0]
service-4-dotnet   |       Content root path: /app
service-1-express  | [x] Broadcasted: {"action":"CREATE_PERSON","name":"AungKo","timestamp":"2026-09-28T03:49:53.516Z"}
service-2-hono     | [Service 2 - Personal Info] Received: {
service-2-hono     |   action: 'CREATE_PERSON',
service-2-hono     |   name: 'AungKo',
service-2-hono     |   timestamp: '2026-09-28T03:49:53.516Z'

service-3-express  | [Service 3 - Relationship Setup] Received: {
service-3-express  |   action: 'CREATE_PERSON',
service-3-express  |   name: 'AungKo',
service-3-express  |   timestamp: '2026-09-28T03:49:53.516Z'
service-3-express  | }
service-2-hono     | }
service-4-dotnet   | [Service 4] Received Message: {"action":"CREATE_PERSON","name":"AungKo","timestamp":"2026-09-28T03:49:53.516Z"}
service-4-dotnet   | info: Microsoft.EntityFrameworkCore.Update[30100]
service-4-dotnet   |       Saved 1 entities to in-memory store.
service-4-dotnet   | [Service 4] Successfully saved person to DB: AungKo
service-2-hono     | [Service 2 - Personal Info] Received: {
service-4-dotnet   | [Service 4] Received Message: {"action":"CREATE_PERSON","name":"Cisco","timestamp":"2026-09-28T03:52:04.342Z"}
service-4-dotnet   | info: Microsoft.EntityFrameworkCore.Update[30100]

service-3-express  | [Service 3 - Relationship Setup] Received: {
service-3-express  |   action: 'CREATE_PERSON',
service-3-express  |   name: 'Cisco',
service-3-express  |   timestamp: '2026-09-28T03:52:04.342Z'
service-3-express  | }
service-4-dotnet   |       Saved 1 entities to in-memory store.
service-4-dotnet   | [Service 4] Successfully saved person to DB: Cisco
service-1-express  | [x] Broadcasted: {"action":"CREATE_PERSON","name":"Cisco","timestamp":"2026-09-28T03:52:04.342Z"}
service-2-hono     |   action: 'CREATE_PERSON',
service-2-hono     |   name: 'Cisco',
service-2-hono     |   timestamp: '2026-09-28T03:52:04.342Z'
service-2-hono     | }
```
