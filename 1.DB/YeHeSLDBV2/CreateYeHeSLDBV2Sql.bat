@rem
@rem �������ݿ�ű�
@rem
@echo ====================
@echo ���� YeHeSLDB - V2 ���ݿ�ű�
@echo ====================
@echo Press any key to continue, Ctrl+C to break...
@pause > nul

"C:\Program Files\Microsoft SQL Server\MSSQL\Upgrade\scptxfr.exe" /s a /d yehesldbv2-3 /P sa /f .\YeHeSLDBV2.sql /q /r /A /E
