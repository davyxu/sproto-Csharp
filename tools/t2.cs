// Generated by sprotodump. DO NOT EDIT!
// source: input

using System;
using Sproto;
using System.Collections.Generic;

namespace SprotoType{ 
	public class Test : SprotoTypeBase {
		private static int max_field_count = 3;
		
		
		private string _v1; // tag 1
		public string v1 {
			get { return _v1; }
			set { base.has_field.set_field (0, true); _v1 = value; }
		}
		public bool HasV1 {
			get { return base.has_field.has_field (0); }
		}

		private Int64 _v2; // tag 2
		public Int64 v2 {
			get { return _v2; }
			set { base.has_field.set_field (1, true); _v2 = value; }
		}
		public bool HasV2 {
			get { return base.has_field.has_field (1); }
		}

		public Test () : base(max_field_count) {}

		public Test (byte[] buffer) : base(max_field_count, buffer) {
			this.decode ();
		}

		protected override void decode () {
			int tag = -1;
			while (-1 != (tag = base.deserialize.read_tag ())) {
				switch (tag) {
				case 1:
					this.v1 = base.deserialize.read_string ();
					break;
				case 2:
					this.v2 = base.deserialize.read_integer ();
					break;
				default:
					base.deserialize.read_unknow_data ();
					break;
				}
			}
		}

		public override int encode (SprotoStream stream) {
			base.serialize.open (stream);

			if (base.has_field.has_field (0)) {
				base.serialize.write_string (this.v1, 1);
			}

			if (base.has_field.has_field (1)) {
				base.serialize.write_integer (this.v2, 2);
			}

			return base.serialize.close ();
		}
	}


}


namespace Protocol{ 
	public class SprotoTypeDefault {
		public static readonly ProtocolFunctionDictionary Protocol = new ProtocolFunctionDictionary ();
		static SprotoTypeDefault() {
			Protocol.SetProtocol<foo4> (foo4.Tag);

		}

		public class foo4 {
			public const int Tag = 1;
		}

	}
}
