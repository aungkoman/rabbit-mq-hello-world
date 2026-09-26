PS D:\Cisco\Code\RabbitMQ> docker-compose up --build
time="2026-09-26T19:55:52+06:30" level=warning msg="D:\\Cisco\\Code\\RabbitMQ\\docker-compose.yml: the attribute `version` is obsolete, it will be ignored, please remove it to avoid potential confusion"
[+] Building 12.1s (28/28) FINISHED                                                                                                                                                                                                                                
 => [internal] load local bake definitions                                                                                                                                                                                                                    0.0s
 => => reading from stdin 1.49kB                                                                                                                                                                                                                              0.0s
 => [service-1 internal] load build definition from Dockerfile                                                                                                                                                                                                0.1s
 => => transferring dockerfile: 146B                                                                                                                                                                                                                          0.0s
 => [service-2 internal] load build definition from Dockerfile                                                                                                                                                                                                0.0s
 => => transferring dockerfile: 146B                                                                                                                                                                                                                          0.0s
 => [service-3 internal] load build definition from Dockerfile                                                                                                                                                                                                0.0s
 => => transferring dockerfile: 146B                                                                                                                                                                                                                          0.0s
 => [service-3 internal] load metadata for docker.io/library/node:18-alpine                                                                                                                                                                                   1.1s
 => [service-2 internal] load .dockerignore                                                                                                                                                                                                                   0.0s
 => => transferring context: 2B                                                                                                                                                                                                                               0.0s
 => [service-1 internal] load .dockerignore                                                                                                                                                                                                                   0.0s
 => => transferring context: 2B                                                                                                                                                                                                                               0.0s
 => [service-3 internal] load .dockerignore                                                                                                                                                                                                                   0.1s
 => => transferring context: 2B                                                                                                                                                                                                                               0.0s
 => [service-3 1/5] FROM docker.io/library/node:18-alpine@sha256:8d6421d663b4c28fd3ebc498332f249011d118945588d0a35cb9bc4b8ca09d9e                                                                                                                             0.1s
 => => resolve docker.io/library/node:18-alpine@sha256:8d6421d663b4c28fd3ebc498332f249011d118945588d0a35cb9bc4b8ca09d9e                                                                                                                                       0.1s
 => [service-2 internal] load build context                                                                                                                                                                                                                   0.1s
 => => transferring context: 264B                                                                                                                                                                                                                             0.0s
 => [service-1 internal] load build context                                                                                                                                                                                                                   0.1s
 => => transferring context: 91B                                                                                                                                                                                                                              0.0s
 => [service-3 internal] load build context                                                                                                                                                                                                                   0.1s
 => => transferring context: 91B                                                                                                                                                                                                                              0.0s
 => CACHED [service-1 2/5] WORKDIR /app                                                                                                                                                                                                                       0.0s
 => CACHED [service-1 3/5] COPY package*.json ./                                                                                                                                                                                                              0.0s
 => CACHED [service-3 3/5] COPY package*.json ./                                                                                                                                                                                                              0.0s
 => [service-1 4/5] RUN npm install                                                                                                                                                                                                                           7.2s
 => [service-3 4/5] RUN npm install                                                                                                                                                                                                                           7.2s
 => [service-2 3/5] COPY package*.json ./                                                                                                                                                                                                                     0.1s
 => [service-2 4/5] RUN npm install                                                                                                                                                                                                                           4.1s
 => [service-2 5/5] COPY . .                                                                                                                                                                                                                                  0.2s 
 => [service-2] exporting to image                                                                                                                                                                                                                            2.6s 
 => => exporting layers                                                                                                                                                                                                                                       1.1s 
 => => exporting manifest sha256:1d0f8caaa37bd7abef9c959ea8802370704cfcf7a4c70b20b4176e6d946e3e06                                                                                                                                                             0.0s 
 => => exporting config sha256:41a23824840372edd8a95454c4ed3f17c5eb532ba25ade57a888af7b87132692                                                                                                                                                               0.0s
 => => exporting attestation manifest sha256:92a754f652bfac6638055bed0d5c5e0fb861967965e486f1d4e8c9df0d580a8d                                                                                                                                                 0.1s
 => => exporting manifest list sha256:f5873d7bc855ab556df65a5b317edef4d229a36dbd0dac0c9266bac2d9e25cb3                                                                                                                                                        0.0s
 => => naming to docker.io/library/rabbitmq-service-2:latest                                                                                                                                                                                                  0.0s
 => => unpacking to docker.io/library/rabbitmq-service-2:latest                                                                                                                                                                                              65.1s
 => [service-3 5/5] COPY . .                                                                                                                                                                                                                                  0.3s
 => [service-1 5/5] COPY . .                                                                                                                                                                                                                                  0.4s
 => [service-3] exporting to image                                                                                                                                                                                                                            2.2s
 => => exporting layers                                                                                                                                                                                                                                       1.0s
 => => exporting manifest sha256:632f65163905d9b6c7fa09dacf807e374dc4748feb8ef84ab015ba8f8808bafb                                                                                                                                                             0.1s
 => => exporting config sha256:8fab9abacd62b57e4acf87f7a04f905078ab4ee8dd62bd7e38e3c6b6f32cd8fc                                                                                                                                                               0.1s
 => => exporting attestation manifest sha256:61d480afaa19b9951a30e9cad008f62ec52da16f0427f80bc0fa8fdf4b9bfc71                                                                                                                                                 0.1s
 => => exporting manifest list sha256:489871331ff15ba996c8e36f946d57f9e0fd2ba1ca779efe651edc76eb57cda2                                                                                                                                                        0.1s
 => => naming to docker.io/library/rabbitmq-service-3:latest                                                                                                                                                                                                  0.0s
 => => unpacking to docker.io/library/rabbitmq-service-3:latest                                                                                                                                                                                               0.7s
 => [service-2] resolving provenance for metadata file                                                                                                                                                                                                        0.0s
 => [service-1] exporting to image                                                                                                                                                                                                                            2.1s
 => => exporting layers                                                                                                                                                                                                                                       1.0s
 => => exporting manifest sha256:6ecf6d60c59566b8b239eba37bf3ad4cb6129757396d0acf7a56fd277b50fe0a                                                                                                                                                             0.0s
 => => exporting config sha256:614770ad726feed0222c97f3b0b55bf6c52d0e7df929ac176e291ccdd6e13392                                                                                                                                                               0.1s
 => => exporting attestation manifest sha256:90be7437d659b4a4cd796af03303a07faacf39437838475f0321a41218cfba0f                                                                                                                                                 0.1s
 => => exporting manifest list sha256:acc736feab87e80b1680e3259c51ceb554bcb58ab82fae513a339422defe9dd4                                                                                                                                                        0.1s
 => => naming to docker.io/library/rabbitmq-service-1:latest                                                                                                                                                                                                  0.0s
 => => unpacking to docker.io/library/rabbitmq-service-1:latest                                                                                                                                                                                               0.6s
 => [service-3] resolving provenance for metadata file                                                                                                                                                                                                        0.1s
 => [service-1] resolving provenance for metadata file                                                                                                                                                                                                        0.0s
[+] Running 8/8
 ✔ rabbitmq-service-1           Built                                                                                                                                                                                                                         0.0s 
 ✔ rabbitmq-service-2           Built                                                                                                                                                                                                                         0.0s 
 ✔ rabbitmq-service-3           Built                                                                                                                                                                                                                         0.0s 
 ✔ Network rabbitmq_default     Created                                                                                                                                                                                                                       0.1s 
 ✔ Container rabbitmq-server    Created                                                                                                                                                                                                                       0.4s 
 ✔ Container service-3-express  Created                                                                                                                                                                                                                       0.3s 
 ✔ Container service-2-hono     Created                                                                                                                                                                                                                       0.3s 
 ✔ Container service-1-express  Created                                                                                                                                                                                                                       0.3s 
Attaching to rabbitmq-server, service-1-express, service-2-hono, service-3-express
service-2-hono  | Service 2 running on port 3002
service-2-hono  | Service 2: Waiting for RabbitMQ...










service-3-express  | Service 3: Waiting for RabbitMQ...

service-1-express  | Service 1: Waiting for RabbitMQ...
service-2-hono     | Service 2: Waiting for RabbitMQ...
service-3-express  | Service 3: Waiting for RabbitMQ...
service-1-express  | Service 1: Waiting for RabbitMQ...
service-2-hono     | Service 2: Waiting for RabbitMQ...
service-3-express  | Service 3: Waiting for RabbitMQ...
service-1-express  | Service 1: Waiting for RabbitMQ...
rabbitmq-server    | 2026-09-26 13:25:10.668815+00:00 [notice] <0.44.0> Application syslog exited with reason: stopped
rabbitmq-server    | 2026-09-26 13:25:10.679023+00:00 [notice] <0.254.0> Logging: switching to configured handler(s); following messages may not be visible in this log output
rabbitmq-server    | 2026-09-26 13:25:10.679988+00:00 [notice] <0.254.0> Logging: configured log handlers are now ACTIVE
rabbitmq-server    | 2026-09-26 13:25:10.708074+00:00 [info] <0.254.0> ra: starting system quorum_queues
rabbitmq-server    | 2026-09-26 13:25:10.708584+00:00 [info] <0.254.0> starting Ra system: quorum_queues in directory: /var/lib/rabbitmq/mnesia/rabbit@504044cb478f/quorum/rabbit@504044cb478f
rabbitmq-server    | 2026-09-26 13:25:10.862187+00:00 [info] <0.268.0> ra system 'quorum_queues' running pre init for 0 registered servers
rabbitmq-server    | 2026-09-26 13:25:10.878728+00:00 [info] <0.269.0> ra: meta data store initialised for system quorum_queues. 0 record(s) recovered
rabbitmq-server    | 2026-09-26 13:25:10.920273+00:00 [notice] <0.274.0> WAL: ra_log_wal init, open tbls: ra_log_open_mem_tables, closed tbls: ra_log_closed_mem_tables
rabbitmq-server    | 2026-09-26 13:25:10.976915+00:00 [info] <0.254.0> ra: starting system coordination
rabbitmq-server    | 2026-09-26 13:25:10.977105+00:00 [info] <0.254.0> starting Ra system: coordination in directory: /var/lib/rabbitmq/mnesia/rabbit@504044cb478f/coordination/rabbit@504044cb478f
rabbitmq-server    | 2026-09-26 13:25:10.988727+00:00 [info] <0.282.0> ra system 'coordination' running pre init for 0 registered servers
rabbitmq-server    | 2026-09-26 13:25:10.992769+00:00 [info] <0.283.0> ra: meta data store initialised for system coordination. 0 record(s) recovered
rabbitmq-server    | 2026-09-26 13:25:10.994030+00:00 [notice] <0.288.0> WAL: ra_coordination_log_wal init, open tbls: ra_coordination_log_open_mem_tables, closed tbls: ra_coordination_log_closed_mem_tables
rabbitmq-server    | 2026-09-26 13:25:11.005374+00:00 [info] <0.254.0> ra: starting system coordination
rabbitmq-server    | 2026-09-26 13:25:11.005635+00:00 [info] <0.254.0> starting Ra system: coordination in directory: /var/lib/rabbitmq/mnesia/rabbit@504044cb478f/coordination/rabbit@504044cb478f
rabbitmq-server    | 2026-09-26 13:25:11.197513+00:00 [info] <0.254.0> Waiting for Khepri leader for 30000 ms, 9 retries left
rabbitmq-server    | 2026-09-26 13:25:11.210543+00:00 [notice] <0.292.0> RabbitMQ metadata store: candidate -> leader in term: 1 machine version: 1
rabbitmq-server    | 2026-09-26 13:25:11.237515+00:00 [info] <0.254.0> Khepri leader elected
rabbitmq-server    | 2026-09-26 13:25:11.237851+00:00 [info] <0.254.0> Waiting for Khepri projections for 30000 ms, 9 retries left
service-2-hono     | Service 2: Waiting for RabbitMQ...
rabbitmq-server    | 2026-09-26 13:25:11.800070+00:00 [info] <0.254.0> 
rabbitmq-server    | 2026-09-26 13:25:11.800070+00:00 [info] <0.254.0>  Starting RabbitMQ 3.13.7 on Erlang 26.2.5.16 [jit]
rabbitmq-server    | 2026-09-26 13:25:11.800070+00:00 [info] <0.254.0>  Copyright (c) 2007-2024 Broadcom Inc and/or its subsidiaries
rabbitmq-server    | 2026-09-26 13:25:11.800070+00:00 [info] <0.254.0>  Licensed under the MPL 2.0. Website: https://rabbitmq.com
rabbitmq-server    | 
rabbitmq-server    |   ##  ##      RabbitMQ 3.13.7
rabbitmq-server    |   ##  ##
rabbitmq-server    |   ##########  Copyright (c) 2007-2024 Broadcom Inc and/or its subsidiaries
rabbitmq-server    |   ######  ##
rabbitmq-server    |   ##########  Licensed under the MPL 2.0. Website: https://rabbitmq.com
rabbitmq-server    | 


service-3-express  | Service 3: Waiting for RabbitMQ...
rabbitmq-server    |   Erlang:      26.2.5.16 [jit]
rabbitmq-server    |   TLS Library: OpenSSL - OpenSSL 3.1.8 11 Feb 2025
rabbitmq-server    |   Release series support status: see https://www.rabbitmq.com/release-information
rabbitmq-server    | 
rabbitmq-server    |   Doc guides:  https://www.rabbitmq.com/docs



service-1-express  | Service 1: Waiting for RabbitMQ...
rabbitmq-server    |   Support:     https://www.rabbitmq.com/docs/contact


rabbitmq-server    |   Tutorials:   https://www.rabbitmq.com/tutorials
rabbitmq-server    |   Monitoring:  https://www.rabbitmq.com/docs/monitoring
rabbitmq-server    |   Upgrading:   https://www.rabbitmq.com/docs/upgrade
rabbitmq-server    | 
rabbitmq-server    |   Logs: <stdout>
rabbitmq-server    | 
rabbitmq-server    |   Config file(s): /etc/rabbitmq/conf.d/10-defaults.conf
rabbitmq-server    | 
rabbitmq-server    |   Starting broker...2026-09-26 13:25:11.802086+00:00 [info] <0.254.0> 
rabbitmq-server    | 2026-09-26 13:25:11.802086+00:00 [info] <0.254.0>  node           : rabbit@504044cb478f
rabbitmq-server    | 2026-09-26 13:25:11.802086+00:00 [info] <0.254.0>  home dir       : /var/lib/rabbitmq
rabbitmq-server    | 2026-09-26 13:25:11.802086+00:00 [info] <0.254.0>  config file(s) : /etc/rabbitmq/conf.d/10-defaults.conf
rabbitmq-server    | 2026-09-26 13:25:11.802086+00:00 [info] <0.254.0>  cookie hash    : t0VYvpp4QXiZRTlHjExjag==
rabbitmq-server    | 2026-09-26 13:25:11.802086+00:00 [info] <0.254.0>  log(s)         : <stdout>
rabbitmq-server    | 2026-09-26 13:25:11.802086+00:00 [info] <0.254.0>  data dir       : /var/lib/rabbitmq/mnesia/rabbit@504044cb478f
rabbitmq-server    | 2026-09-26 13:25:12.822806+00:00 [info] <0.254.0> Running boot step pre_boot defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:12.822888+00:00 [info] <0.254.0> Running boot step rabbit_global_counters defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:12.823292+00:00 [info] <0.254.0> Running boot step rabbit_osiris_metrics defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:12.823503+00:00 [info] <0.254.0> Running boot step rabbit_core_metrics defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:12.824270+00:00 [info] <0.254.0> Running boot step rabbit_alarm defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:12.840593+00:00 [info] <0.329.0> Memory high watermark set to 3144 MiB (3297610956 bytes) of 7862 MiB (8244027392 bytes) total
rabbitmq-server    | 2026-09-26 13:25:12.852005+00:00 [info] <0.331.0> Enabling free disk space monitoring (disk free space: 1021713506304, total memory: 8244027392)
rabbitmq-server    | 2026-09-26 13:25:12.852407+00:00 [info] <0.331.0> Disk free limit set to 50MB
rabbitmq-server    | 2026-09-26 13:25:12.856584+00:00 [info] <0.254.0> Running boot step code_server_cache defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:12.856758+00:00 [info] <0.254.0> Running boot step file_handle_cache defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:12.882248+00:00 [info] <0.334.0> Limiting to approx 1048479 file handles (943629 sockets)
rabbitmq-server    | 2026-09-26 13:25:12.886312+00:00 [info] <0.335.0> FHC read buffering: OFF
rabbitmq-server    | 2026-09-26 13:25:12.886639+00:00 [info] <0.335.0> FHC write buffering: ON
rabbitmq-server    | 2026-09-26 13:25:12.888370+00:00 [info] <0.254.0> Running boot step worker_pool defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:12.893909+00:00 [info] <0.315.0> Will use 6 processes for default worker pool
rabbitmq-server    | 2026-09-26 13:25:12.894224+00:00 [info] <0.315.0> Starting worker pool 'worker_pool' with 6 processes in it
rabbitmq-server    | 2026-09-26 13:25:12.895874+00:00 [info] <0.254.0> Running boot step database defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:12.897080+00:00 [info] <0.254.0> Peer discovery: configured backend: rabbit_peer_discovery_classic_config
rabbitmq-server    | 2026-09-26 13:25:12.905203+00:00 [notice] <0.316.0> Feature flags: attempt to enable `detailed_queues_endpoint`...
rabbitmq-server    | 2026-09-26 13:25:13.255100+00:00 [notice] <0.316.0> Feature flags: `detailed_queues_endpoint` enabled
rabbitmq-server    | 2026-09-26 13:25:13.256132+00:00 [notice] <0.316.0> Feature flags: attempt to enable `quorum_queue_non_voters`...
service-2-hono     | Service 2: Waiting for RabbitMQ...
rabbitmq-server    | 2026-09-26 13:25:13.479616+00:00 [notice] <0.316.0> Feature flags: `quorum_queue_non_voters` enabled
rabbitmq-server    | 2026-09-26 13:25:13.479880+00:00 [notice] <0.316.0> Feature flags: attempt to enable `stream_update_config_command`...
rabbitmq-server    | 2026-09-26 13:25:13.734939+00:00 [notice] <0.316.0> Feature flags: `stream_update_config_command` enabled
rabbitmq-server    | 2026-09-26 13:25:13.735187+00:00 [notice] <0.316.0> Feature flags: attempt to enable `stream_filtering`...
rabbitmq-server    | 2026-09-26 13:25:13.877042+00:00 [notice] <0.316.0> Feature flags: `stream_filtering` enabled
rabbitmq-server    | 2026-09-26 13:25:13.877177+00:00 [notice] <0.316.0> Feature flags: attempt to enable `stream_sac_coordinator_unblock_group`...
rabbitmq-server    | 2026-09-26 13:25:14.024461+00:00 [notice] <0.316.0> Feature flags: `stream_sac_coordinator_unblock_group` enabled

service-3-express  | Service 3: Waiting for RabbitMQ...


rabbitmq-server    | 2026-09-26 13:25:14.024602+00:00 [notice] <0.316.0> Feature flags: attempt to enable `restart_streams`...
service-1-express  | Service 1: Waiting for RabbitMQ...
rabbitmq-server    | 2026-09-26 13:25:14.337635+00:00 [notice] <0.316.0> Feature flags: `restart_streams` enabled
rabbitmq-server    | 2026-09-26 13:25:14.338168+00:00 [notice] <0.316.0> Feature flags: attempt to enable `message_containers`...
rabbitmq-server    | 2026-09-26 13:25:14.481976+00:00 [notice] <0.316.0> Feature flags: `message_containers` enabled
rabbitmq-server    | 2026-09-26 13:25:14.482199+00:00 [notice] <0.316.0> Feature flags: attempt to enable `message_containers_deaths_v2`...
rabbitmq-server    | 2026-09-26 13:25:14.610681+00:00 [notice] <0.316.0> Feature flags: `message_containers_deaths_v2` enabled
rabbitmq-server    | 2026-09-26 13:25:14.611048+00:00 [info] <0.254.0> DB: virgin node -> run peer discovery
rabbitmq-server    | 2026-09-26 13:25:14.611077+00:00 [warning] <0.254.0> Classic peer discovery backend: list of nodes does not contain the local node []
rabbitmq-server    | 2026-09-26 13:25:14.630325+00:00 [notice] <0.44.0> Application mnesia exited with reason: stopped
rabbitmq-server    | 2026-09-26 13:25:14.895142+00:00 [info] <0.254.0> Waiting for Mnesia tables for 30000 ms, 9 retries left
rabbitmq-server    | 2026-09-26 13:25:14.895311+00:00 [info] <0.254.0> Successfully synced tables from a peer
rabbitmq-server    | 2026-09-26 13:25:14.895393+00:00 [info] <0.254.0> Waiting for Mnesia tables for 30000 ms, 9 retries left
rabbitmq-server    | 2026-09-26 13:25:14.895467+00:00 [info] <0.254.0> Successfully synced tables from a peer
rabbitmq-server    | 2026-09-26 13:25:14.906514+00:00 [info] <0.254.0> Waiting for Mnesia tables for 30000 ms, 9 retries left
rabbitmq-server    | 2026-09-26 13:25:14.906693+00:00 [info] <0.254.0> Successfully synced tables from a peer
rabbitmq-server    | 2026-09-26 13:25:14.906922+00:00 [info] <0.254.0> Running boot step tracking_metadata_store defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:14.907051+00:00 [info] <0.560.0> Setting up a table for connection tracking on this node: tracked_connection
rabbitmq-server    | 2026-09-26 13:25:14.907116+00:00 [info] <0.560.0> Setting up a table for per-vhost connection counting on this node: tracked_connection_per_vhost
rabbitmq-server    | 2026-09-26 13:25:14.907230+00:00 [info] <0.560.0> Setting up a table for per-user connection counting on this node: tracked_connection_per_user

service-2-hono     | Service 2: Waiting for RabbitMQ...
service-3-express  | Service 3: Waiting for RabbitMQ...

rabbitmq-server    | 2026-09-26 13:25:14.907287+00:00 [info] <0.560.0> Setting up a table for channel tracking on this node: tracked_channel
rabbitmq-server    | 2026-09-26 13:25:14.907389+00:00 [info] <0.560.0> Setting up a table for channel tracking on this node: tracked_channel_per_user
rabbitmq-server    | 2026-09-26 13:25:14.907522+00:00 [info] <0.254.0> Running boot step networking_metadata_store defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:14.907633+00:00 [info] <0.254.0> Running boot step feature_flags defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:14.907801+00:00 [info] <0.254.0> Running boot step codec_correctness_check defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:14.907830+00:00 [info] <0.254.0> Running boot step external_infrastructure defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:14.907913+00:00 [info] <0.254.0> Running boot step rabbit_event defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:14.908102+00:00 [info] <0.254.0> Running boot step rabbit_registry defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:14.908185+00:00 [info] <0.254.0> Running boot step rabbit_auth_mechanism_amqplain defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:14.908243+00:00 [info] <0.254.0> Running boot step rabbit_auth_mechanism_cr_demo defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:14.908389+00:00 [info] <0.254.0> Running boot step rabbit_auth_mechanism_plain defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:14.908486+00:00 [info] <0.254.0> Running boot step rabbit_exchange_type_direct defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:14.908599+00:00 [info] <0.254.0> Running boot step rabbit_exchange_type_fanout defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:14.908675+00:00 [info] <0.254.0> Running boot step rabbit_exchange_type_headers defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:14.908791+00:00 [info] <0.254.0> Running boot step rabbit_exchange_type_topic defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:14.908831+00:00 [info] <0.254.0> Running boot step rabbit_mirror_queue_mode_all defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:14.908898+00:00 [info] <0.254.0> Running boot step rabbit_mirror_queue_mode_exactly defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:14.908963+00:00 [info] <0.254.0> Running boot step rabbit_mirror_queue_mode_nodes defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:14.909020+00:00 [info] <0.254.0> Running boot step rabbit_priority_queue defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:14.909042+00:00 [info] <0.254.0> Priority queues enabled, real BQ is rabbit_variable_queue
rabbitmq-server    | 2026-09-26 13:25:14.909102+00:00 [info] <0.254.0> Running boot step rabbit_queue_location_client_local defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:14.909139+00:00 [info] <0.254.0> Running boot step rabbit_queue_location_min_masters defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:14.909190+00:00 [info] <0.254.0> Running boot step rabbit_queue_location_random defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:14.909227+00:00 [info] <0.254.0> Running boot step kernel_ready defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:14.909243+00:00 [info] <0.254.0> Running boot step rabbit_sysmon_minder defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:14.909413+00:00 [info] <0.254.0> Running boot step rabbit_epmd_monitor defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:14.910625+00:00 [info] <0.568.0> epmd monitor knows us, inter-node communication (distribution) port: 25672
rabbitmq-server    | 2026-09-26 13:25:14.910847+00:00 [info] <0.254.0> Running boot step guid_generator defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:14.921672+00:00 [info] <0.254.0> Running boot step rabbit_node_monitor defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:14.922091+00:00 [info] <0.572.0> Starting rabbit_node_monitor (in ignore mode)
rabbitmq-server    | 2026-09-26 13:25:14.922220+00:00 [info] <0.254.0> Running boot step delegate_sup defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:14.922658+00:00 [info] <0.254.0> Running boot step rabbit_memory_monitor defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:14.922929+00:00 [info] <0.254.0> Running boot step rabbit_fifo_dlx_sup defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:14.923070+00:00 [info] <0.254.0> Running boot step core_initialized defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:14.923168+00:00 [info] <0.254.0> Running boot step rabbit_channel_tracking_handler defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:14.923276+00:00 [info] <0.254.0> Running boot step rabbit_connection_tracking_handler defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:14.923359+00:00 [info] <0.254.0> Running boot step rabbit_definitions_hashing defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:14.923413+00:00 [info] <0.254.0> Running boot step rabbit_exchange_parameters defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:15.047003+00:00 [info] <0.254.0> Running boot step rabbit_mirror_queue_misc defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:15.048091+00:00 [info] <0.254.0> Running boot step rabbit_policies defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:15.048655+00:00 [info] <0.254.0> Running boot step rabbit_policy defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:15.048720+00:00 [info] <0.254.0> Running boot step rabbit_queue_location_validator defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:15.048811+00:00 [info] <0.254.0> Running boot step rabbit_quorum_memory_manager defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:15.048859+00:00 [info] <0.254.0> Running boot step rabbit_quorum_queue defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:15.049086+00:00 [info] <0.254.0> Running boot step rabbit_stream_coordinator defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:15.049283+00:00 [info] <0.254.0> Running boot step rabbit_vhost_limit defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:15.049357+00:00 [info] <0.254.0> Running boot step rabbit_federation_parameters defined by app rabbitmq_federation
rabbitmq-server    | 2026-09-26 13:25:15.049428+00:00 [info] <0.254.0> Running boot step rabbit_federation_supervisor defined by app rabbitmq_federation
rabbitmq-server    | 2026-09-26 13:25:15.081050+00:00 [info] <0.254.0> Running boot step rabbit_federation_queue defined by app rabbitmq_federation
rabbitmq-server    | 2026-09-26 13:25:15.085486+00:00 [info] <0.254.0> Running boot step rabbit_federation_upstream_exchange defined by app rabbitmq_federation
rabbitmq-server    | 2026-09-26 13:25:15.086786+00:00 [info] <0.254.0> Running boot step rabbit_mgmt_reset_handler defined by app rabbitmq_management

service-2-hono     | Service 2: Waiting for RabbitMQ...
rabbitmq-server    | 2026-09-26 13:25:15.087093+00:00 [info] <0.254.0> Running boot step rabbit_mgmt_db_handler defined by app rabbitmq_management_agent
rabbitmq-server    | 2026-09-26 13:25:15.087294+00:00 [info] <0.254.0> Management plugin: using rates mode 'basic'
rabbitmq-server    | 2026-09-26 13:25:15.088125+00:00 [info] <0.254.0> Running boot step recovery defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:15.157518+00:00 [info] <0.254.0> Running boot step empty_db_check defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:15.157640+00:00 [info] <0.254.0> Will seed default virtual host and user...
rabbitmq-server    | 2026-09-26 13:25:15.157832+00:00 [info] <0.254.0> Adding vhost '/' (description: 'Default virtual host', tags: [])
rabbitmq-server    | 2026-09-26 13:25:15.331263+00:00 [info] <0.632.0> Making sure data directory '/var/lib/rabbitmq/mnesia/rabbit@504044cb478f/msg_stores/vhosts/628WB79CIFDYO9LJI6DKMI09L' for vhost '/' exists
rabbitmq-server    | 2026-09-26 13:25:15.336630+00:00 [info] <0.632.0> Setting segment_entry_count for vhost '/' with 0 queues to '2048'
rabbitmq-server    | 2026-09-26 13:25:15.377448+00:00 [info] <0.632.0> Starting message stores for vhost '/'
rabbitmq-server    | 2026-09-26 13:25:15.377782+00:00 [info] <0.641.0> Message store "628WB79CIFDYO9LJI6DKMI09L/msg_store_transient": using rabbit_msg_store_ets_index to provide index
rabbitmq-server    | 2026-09-26 13:25:15.380669+00:00 [info] <0.632.0> Started message store of type transient for vhost '/'
rabbitmq-server    | 2026-09-26 13:25:15.380981+00:00 [info] <0.645.0> Message store "628WB79CIFDYO9LJI6DKMI09L/msg_store_persistent": using rabbit_msg_store_ets_index to provide index
rabbitmq-server    | 2026-09-26 13:25:15.382498+00:00 [warning] <0.645.0> Message store "628WB79CIFDYO9LJI6DKMI09L/msg_store_persistent": rebuilding indices from scratch
rabbitmq-server    | 2026-09-26 13:25:15.383850+00:00 [info] <0.632.0> Started message store of type persistent for vhost '/'
rabbitmq-server    | 2026-09-26 13:25:15.384604+00:00 [info] <0.632.0> Recovering 0 queues of type rabbit_classic_queue took 47ms
rabbitmq-server    | 2026-09-26 13:25:15.384734+00:00 [info] <0.632.0> Recovering 0 queues of type rabbit_quorum_queue took 0ms
rabbitmq-server    | 2026-09-26 13:25:15.384806+00:00 [info] <0.632.0> Recovering 0 queues of type rabbit_stream_queue took 0ms
rabbitmq-server    | 2026-09-26 13:25:15.449646+00:00 [info] <0.254.0> Created user 'guest'
rabbitmq-server    | 2026-09-26 13:25:15.461126+00:00 [info] <0.254.0> Successfully set user tags for user 'guest' to [administrator]
rabbitmq-server    | 2026-09-26 13:25:15.522952+00:00 [info] <0.254.0> Successfully set permissions for user 'guest' in virtual host '/' to '.*', '.*', '.*'
rabbitmq-server    | 2026-09-26 13:25:15.523093+00:00 [info] <0.254.0> Running boot step rabbit_observer_cli defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:15.523204+00:00 [info] <0.254.0> Running boot step rabbit_looking_glass defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:15.523262+00:00 [info] <0.254.0> Running boot step rabbit_core_metrics_gc defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:15.523629+00:00 [info] <0.254.0> Running boot step background_gc defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:15.523803+00:00 [info] <0.254.0> Running boot step routing_ready defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:15.523828+00:00 [info] <0.254.0> Running boot step pre_flight defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:15.523843+00:00 [info] <0.254.0> Running boot step notify_cluster defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:15.523884+00:00 [info] <0.254.0> Running boot step networking defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:15.523907+00:00 [info] <0.254.0> Running boot step rabbit_quorum_queue_periodic_membership_reconciliation defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:15.524003+00:00 [info] <0.254.0> Running boot step definition_import_worker_pool defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:15.524031+00:00 [info] <0.315.0> Starting worker pool 'definition_import_pool' with 6 processes in it
rabbitmq-server    | 2026-09-26 13:25:15.524353+00:00 [info] <0.254.0> Running boot step cluster_name defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:15.524408+00:00 [info] <0.254.0> Initialising internal cluster ID to 'rabbitmq-cluster-id-wCQl1amVO2FNnSjN7mgw3Q'
service-3-express  | Service 3: Waiting for RabbitMQ...
rabbitmq-server    | 2026-09-26 13:25:15.531117+00:00 [info] <0.254.0> Running boot step virtual_host_reconciliation defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:15.531466+00:00 [info] <0.254.0> Running boot step direct_client defined by app rabbit
rabbitmq-server    | 2026-09-26 13:25:15.531642+00:00 [info] <0.254.0> Running boot step rabbit_federation_exchange defined by app rabbitmq_federation



service-1-express  | Service 1: Waiting for RabbitMQ...
rabbitmq-server    | 2026-09-26 13:25:15.531977+00:00 [info] <0.684.0> Resetting node maintenance status
rabbitmq-server    | 2026-09-26 13:25:16.022468+00:00 [warning] <0.713.0> Deprecated features: `management_metrics_collection`: Feature `management_metrics_collection` is deprecated.
rabbitmq-server    | 2026-09-26 13:25:16.022468+00:00 [warning] <0.713.0> By default, this feature can still be used for now.
rabbitmq-server    | 2026-09-26 13:25:16.022468+00:00 [warning] <0.713.0> Its use will not be permitted by default in a future minor RabbitMQ version and the feature will be removed from a future major RabbitMQ version; actual versions to be determined.
rabbitmq-server    | 2026-09-26 13:25:16.022468+00:00 [warning] <0.713.0> To continue using this feature when it is not permitted by default, set the following parameter in your configuration:
rabbitmq-server    | 2026-09-26 13:25:16.022468+00:00 [warning] <0.713.0>     "deprecated_features.permit.management_metrics_collection = true"
rabbitmq-server    | 2026-09-26 13:25:16.022468+00:00 [warning] <0.713.0> To test RabbitMQ as if the feature was removed, set this in your configuration:
rabbitmq-server    | 2026-09-26 13:25:16.022468+00:00 [warning] <0.713.0>     "deprecated_features.permit.management_metrics_collection = false"
service-2-hono     | Service 2: Waiting for RabbitMQ...
service-3-express  | Service 3: Waiting for RabbitMQ...
service-1-express  | Service 1: Waiting for RabbitMQ...
service-2-hono     | Service 2: Waiting for RabbitMQ...
rabbitmq-server    | 2026-09-26 13:25:21.822505+00:00 [info] <0.750.0> Management plugin: HTTP (non-TLS) listener started on port 15672
rabbitmq-server    | 2026-09-26 13:25:21.822634+00:00 [info] <0.780.0> Statistics database started.
rabbitmq-server    | 2026-09-26 13:25:21.822700+00:00 [info] <0.779.0> Starting worker pool 'management_worker_pool' with 3 processes in it
rabbitmq-server    | 2026-09-26 13:25:21.833078+00:00 [info] <0.798.0> Prometheus metrics: HTTP (non-TLS) listener started on port 15692
rabbitmq-server    | 2026-09-26 13:25:21.833283+00:00 [info] <0.684.0> Ready to start client connection listeners
rabbitmq-server    | 2026-09-26 13:25:21.836131+00:00 [info] <0.842.0> started TCP listener on [::]:5672
rabbitmq-server    |  completed with 5 plugins.
rabbitmq-server    | 2026-09-26 13:25:21.982490+00:00 [info] <0.684.0> Server startup complete; 5 plugins started.
rabbitmq-server    | 2026-09-26 13:25:21.982490+00:00 [info] <0.684.0>  * rabbitmq_prometheus
rabbitmq-server    | 2026-09-26 13:25:21.982490+00:00 [info] <0.684.0>  * rabbitmq_federation
rabbitmq-server    | 2026-09-26 13:25:21.982490+00:00 [info] <0.684.0>  * rabbitmq_management
rabbitmq-server    | 2026-09-26 13:25:21.982490+00:00 [info] <0.684.0>  * rabbitmq_management_agent
rabbitmq-server    | 2026-09-26 13:25:21.982490+00:00 [info] <0.684.0>  * rabbitmq_web_dispatch
rabbitmq-server    | 2026-09-26 13:25:22.062761+00:00 [info] <0.846.0> accepting AMQP connection <0.846.0> (172.18.0.5:50048 -> 172.18.0.2:5672)
rabbitmq-server    | 2026-09-26 13:25:22.116394+00:00 [info] <0.846.0> connection <0.846.0> (172.18.0.5:50048 -> 172.18.0.2:5672): user 'guest' authenticated and granted access to vhost '/'
service-3-express  | Service 3 (Express): Connected to RabbitMQ. Waiting for messages...
rabbitmq-server    | 2026-09-26 13:25:22.165998+00:00 [info] <0.867.0> accepting AMQP connection <0.867.0> (172.18.0.4:52682 -> 172.18.0.2:5672)
rabbitmq-server    | 2026-09-26 13:25:22.175827+00:00 [info] <0.9.0> Time to start RabbitMQ: 17601 ms
rabbitmq-server    | 2026-09-26 13:25:22.216237+00:00 [info] <0.867.0> connection <0.867.0> (172.18.0.4:52682 -> 172.18.0.2:5672): user 'guest' authenticated and granted access to vhost '/'
service-1-express  | Service 1: Connected to RabbitMQ
rabbitmq-server    | 2026-09-26 13:25:23.412654+00:00 [info] <0.881.0> accepting AMQP connection <0.881.0> (172.18.0.3:42534 -> 172.18.0.2:5672)
rabbitmq-server    | 2026-09-26 13:25:23.461816+00:00 [info] <0.881.0> connection <0.881.0> (172.18.0.3:42534 -> 172.18.0.2:5672): user 'guest' authenticated and granted access to vhost '/'
service-2-hono     | Service 2 (Hono): Connected to RabbitMQ. Waiting for messages...