﻿using System;
using System.Collections.Generic;

namespace NHibernateMSSQL.Models
{
	public class Track
	{
		public virtual int Id { get; set; }
		public virtual string Name { get; set; }
		public virtual string Composer { get; set; }
		public virtual int Milliseconds { get; set; }
		public virtual int Bytes { get; set; }
		public virtual Decimal UnitPrice { get; set; }
		public virtual IList<InvoiceLine> InvoiceLines { get; set; }
		public virtual IList<Playlist> Playlists { get; set; }
	}
}