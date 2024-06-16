namespace _12.Ej2AccesoControl.models
{
    public class Controlador
    {
        const int Indice = 100;
        public string[] Patentes = new string[Indice];
        public int[] TipV = new int[Indice];
        public int[] modelo = new int[Indice];
        public int Model = 0;
        public int Cont = 0;
        public string[] PatenElectric = new string[Indice];
        public int[] TiposE = new int[Indice];
        public int[] ModelElectric = new int[Indice];
        public int ModelElec = 0;
        public int ContElectric = 0;
        public int ContTotal = 0;
        public void RegistrarVehiculo(string patentes, int model, int Tipo, bool TiposElectric)
        {
            if (TiposElectric == false)
            {
                Patentes[Cont] = patentes;
                TipV[Cont] = Tipo;
                modelo[Cont] = model;
                Cont++;
                ContTotal++;
            }
            else
            {
                TiposE[ContElectric] = Tipo;
                PatenElectric[ContElectric] = patentes;
                ModelElectric[ContElectric] = model;
                ContElectric++;
                ContTotal++;
            }
        }
        public void ListarElectricos()
        {
            int aux = 0, aux2 = 0;
            string aux3;
            for (int i = 0; i < ContElectric - 1; i++)
            {
                for (int j = i + 1; j < ContElectric; j++)
                {
                    if (ModelElectric[i] > ModelElectric[j])
                    {
                        aux = ModelElectric[i];
                        ModelElectric[i] = ModelElectric[j];
                        ModelElectric[j] = aux;

                        aux2 = TiposE[i];
                        TiposE[i] = TiposE[j];
                        TiposE[j] = aux2;

                        aux3 = PatenElectric[i];
                        PatenElectric[i] = PatenElectric[j];
                        PatenElectric[j] = aux3;
                    }
                }
            }
        }
    }

}

