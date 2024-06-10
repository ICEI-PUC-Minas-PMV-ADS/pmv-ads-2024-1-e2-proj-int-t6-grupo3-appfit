

using Microsoft.AspNetCore.Mvc;
using ProjetifitPlann.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjetifitPlann.Controllers
{
    public class ReceitasController : Controller
    {
        private List<Receitas> receitas = new List<Receitas>
        {
            new Receitas
            {
                Id = 1,
                Nome = "Salada de frutas",
                Descricao = "Uma deliciosa combinação de frutas frescas cortadas em pedaços pequenos, como morangos, bananas, maçãs, uvas e kiwis. A salada é regada com suco de limão e mel para realçar o sabor.",
                Calorias = 120,
                ModoPreparo = "1. Lave e descasque as frutas, cortando-as em pedaços pequenos.\n2. Misture todas as frutas em uma tigela grande.\n3. Regue com suco de limão e mel, misture suavemente.\n4. Deixe refrigerar por alguns minutos antes de servir."
            },
            new Receitas
            {
                Id = 2,
                Nome = "Leguminosas",
                Descricao = "Uma mistura nutritiva de diferentes leguminosas, como lentilhas, feijões e grão-de-bico, cozidos com temperos e ervas aromáticas para um sabor rico e satisfatório.",
                Calorias = 250,
                ModoPreparo = "1. Lave bem as leguminosas e deixe-as de molho em água por algumas horas.\n2. Cozinhe as leguminosas em água fervente até ficarem macias.\n3. Refogue temperos e ervas em uma panela separada.\n4. Misture as leguminosas cozidas com o refogado de temperos e deixe apurar por alguns minutos antes de servir."
            },
            new Receitas
            {
                Id = 3,
                Nome = "Omelete de claras",
                Descricao = "Um omelete leve e saudável feito apenas com claras de ovos, temperado com ervas frescas e vegetais picados para um toque de sabor e nutrição.",
                Calorias = 180,
                ModoPreparo = "1. Bata as claras de ovos até ficarem espumosas.\n2. Adicione temperos e vegetais picados à mistura de ovos.\n3. Despeje a mistura em uma frigideira antiaderente aquecida e cozinhe em fogo médio.\n4. Dobre o omelete ao meio e sirva quente."
            },
            new Receitas
            {
                Id = 4,
                Nome = "Salmão grelhado",
                Descricao = "Salmão fresco grelhado com uma marinada de ervas e suco de limão, resultando em um prato suculento e cheio de sabor, rico em ômega-3 e proteínas.",
                Calorias = 250,
                ModoPreparo = "1. Tempere o salmão com ervas frescas, suco de limão, sal e pimenta.\n2. Deixe marinar por alguns minutos.\n3. Grelhe o salmão em uma frigideira ou churrasqueira quente até ficar cozido por dentro e dourado por fora.\n4. Sirva com uma guarnição de legumes frescos."
            },
            new Receitas
            {
                Id = 5,
                Nome = "Smoothie de frutas vermelhas",
                Descricao = "Um smoothie refrescante e saudável feito com uma mistura de frutas vermelhas, iogurte natural e um toque de mel para adoçar, perfeito para um café da manhã energizante.",
                Calorias = 150,
                ModoPreparo = "1. Combine frutas vermelhas congeladas, iogurte natural e mel em um liquidificador.\n2. Bata até obter uma mistura homogênea e cremosa.\n3. Adicione gelo se desejar uma consistência mais espessa.\n4. Despeje o smoothie em copos e sirva imediatamente."
            },
            new Receitas
            {
                Id = 6,
                Nome = "Quinoa com legumes",
                Descricao = "Um prato saudável e nutritivo feito com quinoa cozida e legumes frescos, temperado com azeite e ervas para um sabor delicioso e equilibrado.",
                Calorias = 280,
                ModoPreparo = "1. Cozinhe a quinoa em água ou caldo até ficar macia e os grãos absorverem o líquido.\n2. Refogue legumes picados em azeite com temperos e ervas a gosto.\n3. Misture a quinoa cozida com os legumes refogados e mexa bem.\n4. Sirva quente como acompanhamento ou prato principal."
            }
        };
        public ActionResult Index(int? minCalorias, int? maxCalorias)
        {
            ViewBag.MinCalorias = minCalorias;
            ViewBag.MaxCalorias = maxCalorias;

            var filtro = receitas.AsQueryable();

            if (minCalorias.HasValue)
            {
                filtro = filtro.Where(r => r.Calorias >= minCalorias.Value);
            }

            if (maxCalorias.HasValue)
            {
                filtro = filtro.Where(r => r.Calorias <= maxCalorias.Value);
            }

            return View(filtro.ToList());
        }
    }
}
