﻿using TAMU.GeoInnovation.Applications.Census.ReferenceDataImporter.FileLayouts.AbstractClasses.Tiger2010.CountryFiles;

namespace TAMU.GeoInnovation.Applications.Census.ReferenceDataImporter.MySql.FileLayouts.Implementations.Tiger2010.CountryFiles
{
    public class Zcta52010File : AbstractTiger2010ShapefileCountryFileLayout
    {

        public Zcta52010File(string stateName)
            : base(stateName)
        {

            FileName = "zcta510.zip";

            SQLCreateTable += "CREATE TABLE IF NOT EXISTS `" + OutputTableName + "` (";
            SQLCreateTable += "zcta5ce10 varchar(5) DEFAULT NULL,";
            SQLCreateTable += "geoId10 varchar(5) DEFAULT NULL,";
            SQLCreateTable += "classFp10 varchar(2) DEFAULT NULL,";
            SQLCreateTable += "Mtfcc10 varchar(5) DEFAULT NULL,";
            SQLCreateTable += "FuncStat10 varchar(1) DEFAULT NULL,";
            SQLCreateTable += "aLand10 varchar(14) DEFAULT NULL,";
            SQLCreateTable += "aWater10 varchar(14) DEFAULT NULL,";
            SQLCreateTable += "intPtLat10 varchar(11) DEFAULT NULL,";
            SQLCreateTable += "intPtLon10 varchar(12) DEFAULT NULL,";
            SQLCreateTable += "shapeType varchar(55), ";
            SQLCreateTable += "shapeGeog geometry NOT NULL,";
            SQLCreateTable += "shapeGeom geometry NOT NULL,";
            SQLCreateTable += "PRIMARY KEY  (zcta5ce10)";
            SQLCreateTable += ");";
            /*
            SQLCreateTableIndexes += " CREATE NONCLUSTERED INDEX [IDX_" + OutputTableName + "zcta5ce10] ON [dbo].[" + OutputTableName + "] (zcta5ce10) WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY];";
            */
        }
    }
}
