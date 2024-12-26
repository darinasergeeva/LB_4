using System;
using System.Collections.Generic;

namespace LB4_AnimeTitlesApp.Models;
//класс модели соответсвует таблице БД 
//экземпляр класса- это строка таблицы БД
public partial class AnimeType
{
    //свойства класса соответствует полям таблицы БД
    public short Id { get; set; }

    public string AnimeOfType { get; set; } = null!;

    //навигационное свойство
    //помогает связывать таблицы в коде 
    //одному типу аниме соответсвует много тайтлов аниме,
    //т.е. создаётся коллекция экземпляров AnimeTitle
    public virtual ICollection<AnimeTitle> AnimeTitles { get; set; } = new List<AnimeTitle>();
}
