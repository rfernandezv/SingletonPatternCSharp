# Singleton Pattern - Net Core 2.1
Singleton Pattern - Net Core 2.1

Se implementaron las siguientes clases en:
SingletonPatternCSharp/Api/Common/Domain/Singleton/
 - LoggerBasicSingleton
 - LoggerThreadSafe1Singleton
 - LoggerThreadSafe2Singleton
 - LoggerThreadSafe3Singleton
 - LoggerThreadSafe4LazySingleton

 Se hace uso del Singleton en la función create de BankAccountsController
 
        {
            //LoggerBasSingleton.Instance.Log("Inicio de función");
            //LoggerThreadSafe1Singleton.Instance.Log("Inicio de función");
            //LoggerThreadSafe2Singleton.Instance.Log("Inicio de función");
            //LoggerThreadSafe3Singleton.Instance.Log("Inicio de función");
            LoggerThreadSafe4LazySingleton.Instance.Log("Inicio de función");

            ....

            _bankAccountRepository.Create(bankAccount);

            LoggerThreadSafe4LazySingleton.Instance.Log("Fin de función");
            
            .....
        }
 