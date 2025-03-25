namespace SharedLibrary.Test
{
    public class ZonaSulProductToGenericProductClass : GenericProductClass
    {
        protected GenericProductClass gpc;
        protected ZonaSulProduct zsp;

        public ZonaSulProductToGenericProductClass(ZonaSulProduct zonaSulProduct, GenericProductClass genericProductClass) : base(genericProductClass.productTitle, genericProductClass.productLink)
        {
            this.gpc = genericProductClass;
            this.zsp = zonaSulProduct;
            // aqui seria a implementação da 
        }
    }
}
