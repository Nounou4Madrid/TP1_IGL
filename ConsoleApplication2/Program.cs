/////////////////////////////////////////////////////////////////////
        //tri par selection
        public void tri_selection()
        {
            for (int i = 0; i < n1 - 1; i++)
            {
                for (int j = i + 1; j < n1; j++)
                {
                    if (tab1[j] < tab1[i])
                    {
                        permut(ref tab1[i], ref tab1[j]);
                    }
                }
            }

        }
        ///////////////////////////////////////////////////
		  //inverser un tableau
        public void invers_tab(int[] tab_invers)
        {
            for (int i = 0; i < n1; i++)
            {
                tab_invers[n1 - 1 - i] = tab1[i];
            }
        }
        //////////////////////////////////////////////////
        //trouver le min et le max dans un tableau
        public void max_min(ref int max, ref int min)
        {
            max = tab1[0];
            min = tab1[0];
            for (int i = 1; i < n1; i++)
            {
                if (max < tab1[i])
                {
                    max = tab1[i];
                }
                if (min > tab1[i])
                {
                    min = tab1[i];
                }
            }
        }