#pragma once


DECLARE_LOG_CATEGORY_EXTERN( Log_UE_CDT, Log, All );


class FUE_CDT_Module : public IModuleInterface
{
public:

	void StartupModule() override;
	void ShutdownModule() override;
};