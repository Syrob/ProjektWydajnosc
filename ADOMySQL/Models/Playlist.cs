﻿using System.Collections.Generic;

namespace ADOMySQL.Models
{
	public class Playlist
	{
		public virtual int Id { get; set; }
		public virtual string Name { get; set; }
		public virtual ISet<Track> Tracks { get; set; }
	}
}