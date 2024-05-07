# Nl-Error-Manager

## Welcome to Nl-Error-Manager Github Page
## Nos plugins sont fait maison et son donc soumis à la license suivante :  GNU GENERAL PUBLIC LICENSE 2.0

## 💾 Comment installer la librairie ?

### 1. Installer le [Nl-Error-Manager.dll](https://github.com/SkyAndCraft/Nl-Error-Manager/releases)
### 2. L'ajouter en référence
### 3. Et ajouter ces ligne dans votre code :

Au dessus de ```public YourClass(IGameAPI api) : base(api)``` :
```C#
private Nl_Error_Manager_Plugin errorManager;
```

Dans ```public YourClass(IGameAPI api) : base(api)``` :
```C#
errorManager = new Nl_Error_Manager_Plugin(api);
```

### Bravo ! La librairie est importé !

### Wiki : [Clique ici](https://github.com/SkyAndCraft/Nl-Error-Manager/wiki)
