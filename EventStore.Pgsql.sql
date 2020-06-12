-- ----------------------------
-- Table structure for "Events"
-- ----------------------------
CREATE TABLE public."Events" (
  "SourceId" uuid NOT NULL,
  "Version" integer NOT NULL,
  "Timestamp" timestamp with time zone NOT NULL,
  "Type" text COLLATE pg_catalog."default" NOT NULL,
  "Data" text COLLATE pg_catalog."default" NOT NULL,
  CONSTRAINT "Events_pkey" PRIMARY KEY ("SourceId", "Version")
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public."Events"
    OWNER to postgres;
-- ----------------------------
-- Table structure for "Snapshots"
-- ----------------------------
CREATE TABLE public."Snapshots" (
  "SourceId" uuid NOT NULL,
  "Version" integer NOT NULL,
  "Timestamp" timestamp with time zone NOT NULL,
  "Type" text COLLATE pg_catalog."default" NOT NULL,
  "Data" text COLLATE pg_catalog."default" NOT NULL,
  CONSTRAINT "Snapshots_pkey" PRIMARY KEY ("SourceId", "Version")
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public."Snapshots"
    OWNER to postgres;