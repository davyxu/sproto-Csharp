// Generated by github.com/davyxu/gosproto/sprotogen
// DO NOT EDIT!
using System;
using Sproto;
using System.Collections.Generic;

namespace SprotoType
{

	public enum MyCar {
		
		Monkey = 1,
		
		Monk = 2,
		
		Pig = 3,
		
	}



	
	public class FakeMyData : SprotoTypeBase {
		private static int max_field_count = 3;
		
		
		[SprotoHasField]
		public bool HasName{
			get { return base.has_field.has_field(0); }
		}
		
		private string _name; // tag 0
		public string name {
			get{ return _name; }
			set{ base.has_field.set_field(0,true); _name = value; }
		}
		
		[SprotoHasField]
		public bool HasType{
			get { return base.has_field.has_field(1); }
		}
		
		private MyCar _type; // tag 1
		public MyCar type {
			get{ return _type; }
			set{ base.has_field.set_field(1,true); _type = value; }
		}
		
		[SprotoHasField]
		public bool HasInt32{
			get { return base.has_field.has_field(2); }
		}
		
		private Int32 _int32; // tag 2
		public Int32 int32 {
			get{ return _int32; }
			set{ base.has_field.set_field(2,true); _int32 = value; }
		}
		
		
		public FakeMyData() : base(max_field_count) {}
		
		public FakeMyData(byte[] buffer) : base(max_field_count, buffer) {
			this.decode ();
		}
		
		protected override void decode () {
			int tag = -1;
			while (-1 != (tag = base.deserialize.read_tag ())) {
				switch (tag) {
				
				case 0:
					this.name = base.deserialize.read_string();
					break;
				
				case 1:
					this.type = base.deserialize.read_enum<MyCar>();
					break;
				
				case 2:
					this.int32 = base.deserialize.read_int32();
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
				base.serialize.write_string(this.name, 0);
			}
			
			if (base.has_field.has_field (1)) {
				base.serialize.write_enum(this.type, 1);
			}
			
			if (base.has_field.has_field (2)) {
				base.serialize.write_int32(this.int32, 2);
			}
			

			return base.serialize.close ();
		}
	}

	
	public class MyData : SprotoTypeBase {
		private static int max_field_count = 7;
		
		
		[SprotoHasField]
		public bool HasName{
			get { return base.has_field.has_field(0); }
		}
		
		private string _name; // tag 0
		public string name {
			get{ return _name; }
			set{ base.has_field.set_field(0,true); _name = value; }
		}
		
		[SprotoHasField]
		public bool HasType{
			get { return base.has_field.has_field(1); }
		}
		
		private MyCar _type; // tag 1
		public MyCar type {
			get{ return _type; }
			set{ base.has_field.set_field(1,true); _type = value; }
		}
		
		[SprotoHasField]
		public bool HasInt32{
			get { return base.has_field.has_field(2); }
		}
		
		private Int32 _int32; // tag 2
		public Int32 int32 {
			get{ return _int32; }
			set{ base.has_field.set_field(2,true); _int32 = value; }
		}
		
		[SprotoHasField]
		public bool HasInt64{
			get { return base.has_field.has_field(3); }
		}
		
		private Int64 _int64; // tag 3
		public Int64 int64 {
			get{ return _int64; }
			set{ base.has_field.set_field(3,true); _int64 = value; }
		}
		
		[SprotoHasField]
		public bool HasAddress{
			get { return base.has_field.has_field(4); }
		}
		
		private string _address; // tag 4
		public string address {
			get{ return _address; }
			set{ base.has_field.set_field(4,true); _address = value; }
		}
		
		[SprotoHasField]
		public bool HasUint32{
			get { return base.has_field.has_field(5); }
		}
		
		private UInt32 _uint32; // tag 5
		public UInt32 uint32 {
			get{ return _uint32; }
			set{ base.has_field.set_field(5,true); _uint32 = value; }
		}
		
		[SprotoHasField]
		public bool HasUint64{
			get { return base.has_field.has_field(6); }
		}
		
		private UInt64 _uint64; // tag 6
		public UInt64 uint64 {
			get{ return _uint64; }
			set{ base.has_field.set_field(6,true); _uint64 = value; }
		}
		
		
		public MyData() : base(max_field_count) {}
		
		public MyData(byte[] buffer) : base(max_field_count, buffer) {
			this.decode ();
		}
		
		protected override void decode () {
			int tag = -1;
			while (-1 != (tag = base.deserialize.read_tag ())) {
				switch (tag) {
				
				case 0:
					this.name = base.deserialize.read_string();
					break;
				
				case 1:
					this.type = base.deserialize.read_enum<MyCar>();
					break;
				
				case 2:
					this.int32 = base.deserialize.read_int32();
					break;
				
				case 3:
					this.int64 = base.deserialize.read_int64();
					break;
				
				case 4:
					this.address = base.deserialize.read_string();
					break;
				
				case 5:
					this.uint32 = base.deserialize.read_uint32();
					break;
				
				case 6:
					this.uint64 = base.deserialize.read_uint64();
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
				base.serialize.write_string(this.name, 0);
			}
			
			if (base.has_field.has_field (1)) {
				base.serialize.write_enum(this.type, 1);
			}
			
			if (base.has_field.has_field (2)) {
				base.serialize.write_int32(this.int32, 2);
			}
			
			if (base.has_field.has_field (3)) {
				base.serialize.write_int64(this.int64, 3);
			}
			
			if (base.has_field.has_field (4)) {
				base.serialize.write_string(this.address, 4);
			}
			
			if (base.has_field.has_field (5)) {
				base.serialize.write_uint32(this.uint32, 5);
			}
			
			if (base.has_field.has_field (6)) {
				base.serialize.write_uint64(this.uint64, 6);
			}
			

			return base.serialize.close ();
		}
	}


    public class RegisterEntry
    {
        static readonly Type[] _types = new Type[]{ 
                typeof(FakeMyData), // 1282909040
                typeof(MyData), // 529527944
            };

        public static Type[] GetClassTypes()
        {
            return _types;
        }
    }
}
