namespace DbVersionMigration.Migrations
{
    //a simple migration
    [Migration(1)]
    public class Version0001 : IMigration
    {
        //run you custom sql here in a transaction
        public void Up()
        {
            //put your sql stuff here in a transaction
        }

        public void Down()
        {
            //put your sql stuff here in a transaction
        }
    }
}