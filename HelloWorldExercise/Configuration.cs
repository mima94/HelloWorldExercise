namespace HelloWorldExercise
{
    public class Configuration
    {
        public static string url = "http://www.helloWorld.rs";
        public static string message = "Podaci koje si uneo/la ne odgovaraju nijednom korisniku";

        public static class Credentials
        {
            public static class ValidCredentials
            {
                public static string Username = "change-me";
                public static string Password = "change-me";
            }

            public static class InvalidCredentials
            {
                public static string Username = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa@aaaa";
                public static string Password = "ahgiaurhiaujrghaujnhg";
            }
        }
    }

}
