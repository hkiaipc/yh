/*
 * 2011-06-17
 * insert tblWaterUserLevel and tblWaterUsertype default values
 */
SET IDENTITY_INSERT tblWaterUserLevel ON
Insert tblWaterUserLevel (WaterUserLevelID,WaterUserLevelName,Ordinal,Deleted,Remark)  values ( 1,'�����',5,0,NULL)
insert tblWaterUserLevel (WaterUserLevelID,WaterUserLevelName,Ordinal,Deleted,Remark)  values ( 2,'����',4,0,NULL)
insert tblWaterUserLevel (WaterUserLevelID,WaterUserLevelName,Ordinal,Deleted,Remark)  values ( 3,'������',3,0,NULL)
insert tblWaterUserLevel (WaterUserLevelID,WaterUserLevelName,Ordinal,Deleted,Remark)  values ( 4,'��',2,0,NULL)
insert tblWaterUserLevel (WaterUserLevelID,WaterUserLevelName,Ordinal,Deleted,Remark)  values ( 5,'����',1,0,NULL)
SET IDENTITY_INSERT tblWaterUserLevel OFF



SET IDENTITY_INSERT tblWaterUsertype ON
insert tblWaterUsertype (WaterUserTypeID,WaterUserTypeName,WaterUserTypeRemark)  values ( 1,'ũҵ','')
insert tblWaterUsertype (WaterUserTypeID,WaterUserTypeName,WaterUserTypeRemark)  values ( 2,'��ҵ','')
insert tblWaterUsertype (WaterUserTypeID,WaterUserTypeName,WaterUserTypeRemark)  values ( 3,'����','')
insert tblWaterUsertype (WaterUserTypeID,WaterUserTypeName,WaterUserTypeRemark)  values ( 4,'����','')
SET IDENTITY_INSERT tblWaterUsertype OFF
