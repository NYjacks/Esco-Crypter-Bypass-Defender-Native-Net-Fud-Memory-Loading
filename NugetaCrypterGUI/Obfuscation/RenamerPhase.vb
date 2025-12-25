Imports dnlib.DotNet.Emit
Imports dnlib.DotNet
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports MONSTERMC.MONSTERMCCrypterGUI.Obfuscation
Namespace MONSTERMCCrypterGUI.Obfuscation
    Friend Class RenamerPhase
        Public Enum RenameMode
            Ascii
            Key
            Normal
        End Enum

        Private Const Ascii As String = "ⒶⒷⒸⒹⒺⒻⒼⒽⒾⒿⓀⓁⓂⓃⓄⓅⓆⓇⓈⓉⓊⓋⓌⓍⓎⓏⓐⓑⓒⓓⓔⓕⓖⓗⓘⓙⓚⓛⓜⓝⓞⓟⓠⓡⓢⓣⓤⓥⓦⓧⓨⓩ⓪①②③④⑤⑥⑦⑧⑨"
        Private Shared ReadOnly Random As Random = New Random()

        Private Shared ReadOnly NormalNameStrings As String() = {"XZ", "YR", "PL", "TG", "F35", "ZAP", "GetApplesFOO", "WHY", "WHEN", "Happy", "SLEEPY", "LOST", "HELLO", "Happy", "BURNED", "HIM", "SAW", "<Initialize>b__13_0", "InitializeLIFE", "FixBOBOBOte", "StBAB", "checkLALALARestart", "QueuePOPOThread", "QueueTETEThread", "RunMOMOAnc", "RUMBLEACTON", "Dance", "FixOPOPOdate", "IXOXOWUWri", "GetVAVAVATypes", "GetTypVAVAFwsFromParentClass", "GetTypwMOMOwesFromParentClass", "GetVAVAVATypesFromInterface", "GetTypesLOLOMAMomInterface", "geTAFAfeout", "setTATADate", "GetILYrequest", "geWOWID64", "set_LOLID64", "get_HELLOID", "set_WOWID", "getTYTYneState", "setLLState", "getILOVEMessage", "SLEEPYMessage", "get_HEY", "set_BYEState", "getBYEState", "set_VAVAGState", "getEGGcon", "set_NEWIcon", "get_CHILLMedium", "set_MELLOMedium", "gBYEBYEfull", "set_HELLOfull", "getMOMOBOBanned", "set_LOVEganed", "get_OOFage", "set_CUDDLEState", "getWOWmoment", "set_KISSstate", "geSMILEURL", "seSMILEURL", "gLULLcute", "sBYEGWAVE", "get_LALALWeeks", "set_SLEEPOWEEKS", "gHUGGONE", "set_KISSGoodbye", "LEAVEaction", "sLULLABYon", "geCUDDLEName", "seCUDDLEName", "gLOVEmama", "HUGbaby", "get_MOMOGames", "set_MostPlayedGames", "get_Groups", "set_Groups", "Reload", "ParseApple", "ParseSun", "ParseEagle", "ParseOcean", "ParseStar", "ParseMoon", "ParseSky", "ParseFire", "ParseWater", "LoadDefaults", "LoadDefaults", "get_Cats", "Happy", "handleDance", "FixedDance", "Broadcast", "OnDestroy", "Read", "Send", "<Happy>b__8_0", "get_SmileID", "set_SmileID", "get_DanceTime", "set_DanceTime", "Send", "Read", "Close", "get_City", "get_Star", "set_Star", "Save", "Load", "Unload", "Load", "Save", "Load", "get_Settings", "LoadPlugin", "<.ctor>b__3_0", "<LoadPlugin>b__4_0", "add_OnPluginUnloading", "remove_OnPluginUnloading", "add_OnPluginLoading", "remove_OnPluginLoading", "get_Translations", "get_State", "get_Assembly", "set_Assembly", "get_Directory", "set_Directory", "get_Name", "set_Name", "get_PluginData", "set_PluginData", "get_PluginSettings", "set_PluginSettings", "get_IsActive", "set_IsActive", "get_Version", "set_Version", "get_Description", "set_Description", "get_Author", "set_Author", "get_Website", "set_Website", "get_Dependencies", "set_Dependencies", "get_LoadOrder", "set_LoadOrder", "get_Priority", "set_Priority", "get_IsHidden", "set_IsHidden", "get_IsDebug", "set_IsDebug", "get_IsStandalone", "set_IsStandalone", "get_RequireRestart", "set_RequireRestart", "get_HasUpdate", "set_HasUpdate", "get_UpdateVersion", "set_UpdateVersion", "get_UpdateURL", "set_UpdateURL", "get_IsCustom", "set_IsCustom", "get_CustomSettings", "set_CustomSettings", "get_IsDeleted", "set_IsDeleted", "get_DeletedBy", "set_DeletedBy", "get_DeletedDate", "set_DeletedDate", "get_IsCompatible", "set_IsCompatible", "get_CompatibilityNotes", "set_CompatibilityNotes", "get_HasWarnings", "set_HasWarnings", "get_Warnings", "set_Warnings", "get_HasErrors", "set_HasErrors", "get_Errors", "set_Errors", "get_LoadErrors", "set_LoadErrors", "get_EnabledPlugins", "get_DisabledPlugins", "get_AvailablePlugins", "get_LockedPlugins", "get_PluginCount", "get_HiddenPluginCount", "get_CustomPluginCount", "get_UnloadedPluginCount", "get_ActivePluginCount", "get_InactivePluginCount", "get_ErrorPluginCount", "get_WarningPluginCount", "get_PluginWarningCount", "get_LoadWarningCount", "get_PluginErrorCount", "get_LoadErrorCount", "get_PluginUpdateCount", "get_UpdateablePluginCount", "get_HasUpdateablePlugins", "get_IsUpdating", "get_IsCheckingForUpdates", "get_UpdateProgress", "get_IsLoadingDefaults", "get_IsReloading", "get_IsSaving", "get_IsLoading", "get_IsUnloading", "get_IsUpdatingSettings", "get_IsUpdatingPlugins", "get_IsDeletingPlugins", "get_IsCleaningUp", "get_IsUpdatingCompatibility", "get_IsPerformingAction", "get_IsRefreshingUI", "get_IsSortingPlugins", "get_IsFilteringPlugins", "get_IsSearchingPlugins", "get_IsLoadingTranslations", "get_IsLoadingPluginData", "get_IsLoadingPluginSettings", "get_IsLoadingPluginDependencies", "get_IsLoadingPluginLoadOrder", "get_IsLoadingPluginPriority", "get_IsLoadingPluginIsHidden", "get_IsLoadingPluginIsDebug", "get_IsLoadingPluginIsStandalone", "get_IsLoadingPluginRequireRestart", "get_IsLoadingPluginHasUpdate", "get_IsLoadingPluginUpdateVersion", "get_IsLoadingPluginUpdateURL", "get_IsLoadingPluginIsCustom", "get_IsLoadingPluginCustomSettings", "get_IsLoadingPluginIsDeleted", "get_IsLoadingPluginDeletedBy", "get_IsLoadingPluginDeletedDate", "get_IsLoadingPluginIsCompatible", "get_IsLoadingPluginCompatibilityNotes", "get_IsLoadingPluginHasWarnings", "get_IsLoadingPluginWarnings", "get_IsLoadingPluginHasErrors", "get_IsLoadingPluginErrors", "get_IsLoadingPluginLoadErrors", "get_IsLoadingPluginEnabledPlugins", "get_IsLoadingPluginDisabledPlugins", "get_IsLoadingPluginAvailablePlugins"}

        Private Shared ReadOnly Names As Dictionary(Of String, String) = New Dictionary(Of String, String)()

        Private Shared Function RandomString(ByVal length As Integer, ByVal chars As String) As String
            Return New String(Enumerable.Repeat(chars, length).[Select](Function(s) s(Random.Next(s.Length))).ToArray())
        End Function

        Private Shared Function GetRandomName() As String
            Return NormalNameStrings(Random.Next(NormalNameStrings.Length))
        End Function

        Public Shared Function GenerateString(ByVal mode As RenameMode) As String
            'Return
        End Function


        Public Shared Sub ExecuteClassRenaming(ByVal [module] As ModuleDefMD)

            Dim nameValue As String = Nothing
            For Each type In [module].GetTypes()
                If type.IsGlobalModuleType Then Continue For

                If type.Name Is "GeneratedInternalTypeHelper" OrElse type.Name Is "Resources" OrElse type.Name Is "Settings" Then Continue For

                If type.FullName.Contains(".My") Then Continue For

                If Names.TryGetValue(type.Name, nameValue) Then
                    type.Name = nameValue
                Else
                    Dim newName = GenerateString(RenameMode.Normal)

                    Names.Add(type.Name, newName)
                    type.Name = newName
                End If
            Next

            ApplyChangesToResourcesClasses([module])
        End Sub


        Private Shared Sub ApplyChangesToResourcesClasses(ByVal [module] As ModuleDefMD)
            Dim moduleToRename = [module]
            For Each resource In moduleToRename.Resources
                For Each item In Names
                    If resource.Name.Contains(item.Key) Then resource.Name = resource.Name.Replace(item.Key, item.Value)
                Next
            Next
            For Each type In moduleToRename.GetTypes()
                For Each [property] In type.Properties
                    If [property].Name IsNot "ResourceManager" Then Continue For

                    Dim instr = [property].GetMethod.Body.Instructions

                    For i = 0 To instr.Count - 3 - 1
                        If instr(i).OpCode Is OpCodes.Ldstr Then
                            Dim predicate As Func(Of KeyValuePair(Of String, String), Boolean) = Function(item) Equals(item.Key, instr(i).Operand.ToString())

                            For Each item In Names.Where(predicate)
                                instr(i).Operand = item.Value
                            Next
                        End If
                    Next
                Next
            Next
        End Sub


        Public Shared Sub ExecuteFieldRenaming(ByVal [module] As ModuleDefMD)
            Dim nameValue As String = Nothing
            For Each type In [module].GetTypes()
                If type.IsGlobalModuleType Then Continue For

                If type.FullName.Contains(".My") Then Continue For
                For Each field In type.Fields

                    If Names.TryGetValue(field.Name, nameValue) Then
                        field.Name = nameValue
                    Else
                        Dim newName = GenerateString(RenameMode.Ascii)

                        Names.Add(field.Name, newName)
                        field.Name = newName
                    End If
                Next
            Next

            ApplyChangesToResourcesField([module])
        End Sub

        Private Shared Sub ApplyChangesToResourcesField(ByVal [module] As ModuleDefMD)
            For Each type In [module].GetTypes()
                If Not type.IsGlobalModuleType Then
                    If type.FullName.Contains(".My") Then Continue For
                    For Each methodDef In type.Methods
                        If methodDef.Name IsNot "InitializeComponent" Then
                            If Not methodDef.HasBody Then Continue For

                            Dim instructions = methodDef.Body.Instructions
                            For i = 0 To instructions.Count - 3 - 1
                                If instructions(i).OpCode Is OpCodes.Ldstr Then
                                    For Each keyValuePair In Names
                                        If Equals(keyValuePair.Key, instructions(i).Operand.ToString()) Then instructions(i).Operand = keyValuePair.Value
                                    Next
                                End If
                            Next
                        End If
                    Next
                End If
            Next
        End Sub

        Public Shared Sub ExecuteMethodRenaming(ByVal [module] As ModuleDefMD)
            For Each type In [module].GetTypes()
                If type.IsGlobalModuleType Then Continue For
                If type.FullName.Contains(".My") Then Continue For

                If type.Name Is "GeneratedInternalTypeHelper" Then Continue For

                For Each method In type.Methods
                    If Not method.HasBody Then Continue For

                    If method.Name Is ".ctor" OrElse method.Name Is ".cctor" Then Continue For

                    method.Name = GenerateString(RenameMode.Ascii)
                Next
            Next
        End Sub

        Public Shared Sub ExecuteModuleRenaming(ByVal [mod] As ModuleDefMD)
            For Each [module] In [mod].Assembly.Modules
                Dim isWpf = False
                For Each asmRef In [module].GetAssemblyRefs()
                    If asmRef.Name Is "WindowsBase" OrElse asmRef.Name Is "PresentationCore" OrElse asmRef.Name Is "PresentationFramework" OrElse asmRef.Name Is "System.Xaml" Then isWpf = True
                Next

                If Not isWpf Then
                    [module].Name = GenerateString(RenameMode.Ascii)

                    [module].Assembly.CustomAttributes.Clear()
                    [module].Mvid = Guid.NewGuid()
                    [module].Assembly.Name = GenerateString(RenameMode.Ascii)
                    [module].Assembly.Version = New Version(Random.Next(1, 9), Random.Next(1, 9), Random.Next(1, 9), Random.Next(1, 9))
                End If
            Next
        End Sub

        Public Shared Sub ExecuteNamespaceRenaming(ByVal [module] As ModuleDefMD)

            Dim nameValue As String = Nothing
            For Each type In [module].GetTypes()
                If type.IsGlobalModuleType Then Continue For

                If type.FullName.Contains(".My") Then Continue For

                If type.Namespace Is "" Then Continue For

                If Names.TryGetValue(type.Namespace, nameValue) Then
                    type.Namespace = nameValue
                Else
                    Dim newName = GenerateString(RenameMode.Ascii)

                    Names.Add(type.Namespace, newName)
                    type.Namespace = newName
                End If
            Next

            ApplyChangesToResourcesNamespace([module])
        End Sub

        Private Shared Sub ApplyChangesToResourcesNamespace(ByVal [module] As ModuleDefMD)
            For Each resource In [module].Resources
                Dim predicate1 As Func(Of KeyValuePair(Of String, String), Boolean) = Function(item) resource.Name.Contains(item.Key)

                For Each item In Names.Where(predicate1)
                    resource.Name = resource.Name.Replace(item.Key, item.Value)
                Next
            Next

            For Each type In [module].GetTypes()
                For Each [property] In type.Properties
                    If [property].Name IsNot "ResourceManager" Then Continue For

                    Dim instr = [property].GetMethod.Body.Instructions

                    For i = 0 To instr.Count - 3 - 1
                        If instr(i).OpCode Is OpCodes.Ldstr Then
                            Dim predicate As Func(Of KeyValuePair(Of String, String), Boolean) = Function(item) Equals(item.Key, instr(i).Operand.ToString())

                            For Each item In Names.Where(predicate)
                                instr(i).Operand = item.Value
                            Next
                        End If
                    Next
                Next
            Next
        End Sub

        Public Shared Sub ExecutePropertiesRenaming(ByVal [module] As ModuleDefMD)
            For Each type In [module].GetTypes()
                If type.IsGlobalModuleType Then Continue For

                For Each [property] In type.Properties
                    [property].Name = GenerateString(RenameMode.Ascii)
                Next
            Next
        End Sub
    End Class
End Namespace
