@rem
@rem ����CZGR���ݿ�ű�
@rem
@echo ====================
@echo ����YeHeSLDB���ݿ�ű�
@echo ====================
@echo Press any key to continue, Ctrl+C to break...
@pause > nul

"C:\Program Files\Microsoft SQL Server\MSSQL\Upgrade\scptxfr.exe" /s 192.168.1.213 /d yehesldb /P sa /f .\YeHeSLDB.sql /q /r /A /E
