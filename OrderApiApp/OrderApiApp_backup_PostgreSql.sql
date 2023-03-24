DROP TABLE IF EXISTS "public"."__EFMigrationsHistory";
-- This script only contains the table creation statements and does not fully represent the table in the database. It's still missing: indices, triggers. Do not use it as a backup.

-- Table Definition
CREATE TABLE "public"."__EFMigrationsHistory" (
    "MigrationId" varchar(150) NOT NULL,
    "ProductVersion" varchar(32) NOT NULL,
    PRIMARY KEY ("MigrationId")
);

DROP TABLE IF EXISTS "public"."Client";
-- This script only contains the table creation statements and does not fully represent the table in the database. It's still missing: indices, triggers. Do not use it as a backup.

-- Table Definition
CREATE TABLE "public"."Client" (
    "Id" int4 NOT NULL,
    "Name" text NOT NULL,
    PRIMARY KEY ("Id")
);

DROP TABLE IF EXISTS "public"."Order";
-- This script only contains the table creation statements and does not fully represent the table in the database. It's still missing: indices, triggers. Do not use it as a backup.

-- Table Definition
CREATE TABLE "public"."Order" (
    "Id" int4 NOT NULL,
    "Description" text NOT NULL,
    "ClientId" int4 NOT NULL,
    CONSTRAINT "FK_Order_Client_ClientId" FOREIGN KEY ("ClientId") REFERENCES "public"."Client"("Id") ON DELETE CASCADE,
    PRIMARY KEY ("Id")
);

DROP TABLE IF EXISTS "public"."Product";
-- This script only contains the table creation statements and does not fully represent the table in the database. It's still missing: indices, triggers. Do not use it as a backup.

-- Table Definition
CREATE TABLE "public"."Product" (
    "Id" int4 NOT NULL,
    "Name" text NOT NULL,
    "Article" int4 NOT NULL,
    "Cost" float8 NOT NULL,
    PRIMARY KEY ("Id")
);

DROP TABLE IF EXISTS "public"."Receipt";
-- This script only contains the table creation statements and does not fully represent the table in the database. It's still missing: indices, triggers. Do not use it as a backup.

-- Table Definition
CREATE TABLE "public"."Receipt" (
    "Id" int4 NOT NULL,
    "Quantity" int4 NOT NULL,
    "OrderId" int4 NOT NULL,
    "ProductId" int4 NOT NULL,
    CONSTRAINT "FK_Receipt_Order_OrderId" FOREIGN KEY ("OrderId") REFERENCES "public"."Order"("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_Receipt_Product_ProductId" FOREIGN KEY ("ProductId") REFERENCES "public"."Product"("Id") ON DELETE CASCADE,
    PRIMARY KEY ("Id")
);

DROP VIEW IF EXISTS "public"."pg_stat_statements";
 SELECT pg_stat_statements.userid,
    pg_stat_statements.dbid,
    pg_stat_statements.queryid,
    pg_stat_statements.query,
    pg_stat_statements.plans,
    pg_stat_statements.total_plan_time,
    pg_stat_statements.min_plan_time,
    pg_stat_statements.max_plan_time,
    pg_stat_statements.mean_plan_time,
    pg_stat_statements.stddev_plan_time,
    pg_stat_statements.calls,
    pg_stat_statements.total_exec_time,
    pg_stat_statements.min_exec_time,
    pg_stat_statements.max_exec_time,
    pg_stat_statements.mean_exec_time,
    pg_stat_statements.stddev_exec_time,
    pg_stat_statements.rows,
    pg_stat_statements.shared_blks_hit,
    pg_stat_statements.shared_blks_read,
    pg_stat_statements.shared_blks_dirtied,
    pg_stat_statements.shared_blks_written,
    pg_stat_statements.local_blks_hit,
    pg_stat_statements.local_blks_read,
    pg_stat_statements.local_blks_dirtied,
    pg_stat_statements.local_blks_written,
    pg_stat_statements.temp_blks_read,
    pg_stat_statements.temp_blks_written,
    pg_stat_statements.blk_read_time,
    pg_stat_statements.blk_write_time,
    pg_stat_statements.wal_records,
    pg_stat_statements.wal_fpi,
    pg_stat_statements.wal_bytes
   FROM pg_stat_statements(true) pg_stat_statements(userid, dbid, queryid, query, plans, total_plan_time, min_plan_time, max_plan_time, mean_plan_time, stddev_plan_time, calls, total_exec_time, min_exec_time, max_exec_time, mean_exec_time, stddev_exec_time, rows, shared_blks_hit, shared_blks_read, shared_blks_dirtied, shared_blks_written, local_blks_hit, local_blks_read, local_blks_dirtied, local_blks_written, temp_blks_read, temp_blks_written, blk_read_time, blk_write_time, wal_records, wal_fpi, wal_bytes);

INSERT INTO "public"."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES
('20230319112144_Init', '7.0.4');
INSERT INTO "public"."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES
('20230319151927_NewInit', '7.0.4');
INSERT INTO "public"."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES
('20230319154143_NewNewInit', '7.0.4');
INSERT INTO "public"."__EFMigrationsHistory" ("MigrationId", "ProductVersion") VALUES
('20230319155601_UpdateAndInit', '7.0.4'),
('20230324171229_Multi-Tables', '7.0.4');

INSERT INTO "public"."Client" ("Id", "Name") VALUES
(1, 'Ivan');
INSERT INTO "public"."Client" ("Id", "Name") VALUES
(2, 'Stepan');
INSERT INTO "public"."Client" ("Id", "Name") VALUES
(3, 'Valerian');
INSERT INTO "public"."Client" ("Id", "Name") VALUES
(4, 'Dmitriy'),
(5, 'Roman'),
(6, 'Frank');

INSERT INTO "public"."Order" ("Id", "Description", "ClientId") VALUES
(1, 'Заказ 1', 1);
INSERT INTO "public"."Order" ("Id", "Description", "ClientId") VALUES
(2, 'Заказ 2', 2);
INSERT INTO "public"."Order" ("Id", "Description", "ClientId") VALUES
(3, 'Заказ 3', 3);
INSERT INTO "public"."Order" ("Id", "Description", "ClientId") VALUES
(4, 'Заказ 4', 4),
(5, 'Заказ 5', 5),
(6, 'Заказ 6', 6);

INSERT INTO "public"."Product" ("Id", "Name", "Article", "Cost") VALUES
(1, 'Ручка', 1001, 55.5);
INSERT INTO "public"."Product" ("Id", "Name", "Article", "Cost") VALUES
(2, 'Карандаш', 1002, 15);
INSERT INTO "public"."Product" ("Id", "Name", "Article", "Cost") VALUES
(3, 'Стержень', 1003, 1.5);
INSERT INTO "public"."Product" ("Id", "Name", "Article", "Cost") VALUES
(4, 'Блокнот', 1004, 100),
(5, 'Тетрадь', 1005, 25.33),
(6, 'Файлы', 1006, 65);

INSERT INTO "public"."Receipt" ("Id", "Quantity", "OrderId", "ProductId") VALUES
(3, 5, 1, 1);
INSERT INTO "public"."Receipt" ("Id", "Quantity", "OrderId", "ProductId") VALUES
(4, 4, 1, 2);
INSERT INTO "public"."Receipt" ("Id", "Quantity", "OrderId", "ProductId") VALUES
(5, 3, 1, 5);
INSERT INTO "public"."Receipt" ("Id", "Quantity", "OrderId", "ProductId") VALUES
(6, 10, 2, 4),
(7, 3, 2, 2),
(8, 4, 3, 3),
(9, 5, 3, 2),
(10, 1, 4, 5),
(11, 2, 4, 6),
(12, 3, 4, 1),
(13, 7, 5, 1),
(14, 9, 6, 3);

