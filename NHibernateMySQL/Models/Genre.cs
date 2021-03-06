﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHibernateMySQL.Models
{
	public class Genre
	{
		public virtual int Id { get; set; }
		public virtual string Name { get; set; }
		public virtual ISet<Track> Tracks { get; set; }
	}
}