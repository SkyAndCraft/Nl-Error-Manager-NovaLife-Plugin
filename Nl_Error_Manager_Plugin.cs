using Life;
using Life.Network;
using UnityEngine;

namespace Nl_Error_Manager
{
    public class Nl_Error_Manager_Plugin : Plugin
    {
        public Nl_Error_Manager_Plugin(IGameAPI api) : base(api)
        {
        }

        public void Error_Dir_Creation(string PluginName, string DirName, string Path)
        {
            Debug.LogError("Le plugin " + PluginName + " n'a pas réussi à créer le dossier " + DirName + " situé au chemin suivant : " + Path);
        }

        public void Error_Dir_Search(string PluginName, string DirName)
        {
            Debug.LogError("Le plugin " + PluginName + " n'a pas réussi à accédé au dossier " + DirName);
        }

        public void Error_File_Creation(string PluginName, string FileName, string Path)
        {
            Debug.LogError("Le plugin " + PluginName + " n'a pas réussi à créer le fichier " + FileName + " situé au chemin suivant : " + Path);
        }
        public void Error_File_Search(string PluginName, string FileName)
        {
            Debug.LogError("Le plugin " + PluginName + " n'a pas réussi à accédé le fichier " + FileName);
        }

        public void Init_Failed_Missing_Dependency(string PluginName, string DependencyName) 
        {
            Debug.LogError("Le plugin " + PluginName + " à besoin de la dépendance " +  DependencyName);
        }

        public void Init_Succefull(string PluginName)
        {
            Debug.Log("Le plugin " + PluginName + " est initialisé avec succès !");
        }

        public void Error_Database_creation(string PluginName, string DatabaseName, string Path)
        {
            Debug.LogError("Le plugin " + PluginName + " n'a pas réussi à créer la database " + DatabaseName + " au chemin suivant : " + Path);
        }

        //In-Game Error

        public void IG_Error_TaskFailed(string PluginName, string ErrorID, string ErrorDesc, Player player, float Duration) 
        {
            player.Notify(PluginName + " | " + ErrorID, ErrorDesc, NotificationManager.Type.Error, Duration);
        }
        
        public void IG_TaskGranted(string PluginName, string TaskName, string TaskDesc, Player player, float Duration) 
        { 
            player.Notify(PluginName + " | " +  TaskName, TaskDesc, NotificationManager.Type.Success, Duration);
        }

        public void IG_Infos(string PluginName, string InfoName, string InfoDesc, Player player, float Duration)
        {
            player.Notify(PluginName + " | " + InfoName, InfoDesc, NotificationManager.Type.Info, Duration);
        }

        public void IG_Warn(string PluginName, string WarnName, string WarnDesc, Player player, float Duration)
        {
            player.Notify(PluginName + " | " + WarnName, WarnDesc, NotificationManager.Type.Warning, Duration);
        }

        public override void OnPluginInit()
        {
            base.OnPluginInit();
            Init_Succefull("NL-Error-Manager");
        }
    }
}
