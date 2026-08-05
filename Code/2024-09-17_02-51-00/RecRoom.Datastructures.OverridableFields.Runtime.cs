using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using Cpp2IlInjected;
using Google.Protobuf;
using JetBrains.Annotations;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface BPFKIBNMAMA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EGNFNLBOOHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object BJEDDKIOPJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CLDMJNFPMPI<T> : BPFKIBNMAMA
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T PGPGCBGPPOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface NODJOJKLAKN<T> : CLDMJNFPMPI<T>, BPFKIBNMAMA
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool EGNFNLBOOHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T PGPGCBGPPOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface AIOFKIDIMGD<T> : NODJOJKLAKN<T>, CLDMJNFPMPI<T>, BPFKIBNMAMA
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool PBEKNPBDFMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RecRoom.Utils.OverridableFields
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct OverridableInt : CLDMJNFPMPI<int>, BPFKIBNMAMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private int value;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9CA310", Offset = "0x9C8D10", VA = "0x1809CA310", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6C23F10", Offset = "0x6C22910", VA = "0x186C23F10", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2710A10", Offset = "0x270F410", VA = "0x182710A10", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6C23E70", Offset = "0x6C22870", VA = "0x186C23E70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : CLDMJNFPMPI<string>, BPFKIBNMAMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private string value;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9CA310", Offset = "0x9C8D10", VA = "0x1809CA310", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xB0FDE0", Offset = "0xB0E7E0", VA = "0x180B0FDE0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xB0FDE0", Offset = "0xB0E7E0", VA = "0x180B0FDE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6C23F60", Offset = "0x6C22960", VA = "0x186C23F60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : NODJOJKLAKN<InnerType>, CLDMJNFPMPI<InnerType>, BPFKIBNMAMA where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool EGNFNLBOOHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType PGPGCBGPPOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object BJEDDKIOPJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x22E7590", Offset = "0x22E5F90", VA = "0x1822E7590", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x47CF9B0", Offset = "0x47CE3B0", VA = "0x1847CF9B0")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x47CF9E0", Offset = "0x47CE3E0", VA = "0x1847CF9E0")]
		public MutableOverridableBase(bool AOFHMNBLLIM, [NotNull] InnerType KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x47CF1C0", Offset = "0x47CDBC0", VA = "0x1847CF1C0", Slot = "15")]
		public void BGHBPLODFDC(CLDMJNFPMPI<InnerType> NDHCCLMPCNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x47CF660", Offset = "0x47CE060", VA = "0x1847CF660", Slot = "16")]
		public void DODCOAEGADP(CLDMJNFPMPI<InnerType> PLNBHPCFEOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x47CF8B0", Offset = "0x47CE2B0", VA = "0x1847CF8B0", Slot = "17")]
		public virtual void LFBMALNLGLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType OHNLHFDAOKO();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void IGBPCPFLJBG(ProtobufType BHLHDOJEGCE);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void GFEKPLIEPFB(byte[] NANIBGLOJNL);
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public abstract class SerializedMutableOverridableBase<T, InnerType, ProtobufType> : MutableOverridableBase<T, InnerType, ProtobufType> where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private InnerType value;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x923890", Offset = "0x922290", VA = "0x180923890", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x923B70", Offset = "0x922570", VA = "0x180923B70", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1FE7530", Offset = "0x1FE5F30", VA = "0x181FE7530", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3E5C460", Offset = "0x3E5AE60", VA = "0x183E5C460")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x478C9E0", Offset = "0x478B3E0", VA = "0x18478C9E0")]
		public SerializedMutableOverridableBase(bool AOFHMNBLLIM, InnerType KLABJGGMBGH)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, KLCJDDFKMOF>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6C23DA0", Offset = "0x6C227A0", VA = "0x186C23DA0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6C23E00", Offset = "0x6C22800", VA = "0x186C23E00")]
		public MutableOverridableObscuredInt(bool AOFHMNBLLIM, ObscuredInt KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6C23CD0", Offset = "0x6C226D0", VA = "0x186C23CD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6C23A70", Offset = "0x6C22470", VA = "0x186C23A70", Slot = "20")]
		public override void GFEKPLIEPFB(byte[] NANIBGLOJNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6C23B40", Offset = "0x6C22540", VA = "0x186C23B40", Slot = "19")]
		public override void IGBPCPFLJBG(KLCJDDFKMOF BHLHDOJEGCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6C23BF0", Offset = "0x6C225F0", VA = "0x186C23BF0", Slot = "18")]
		public override KLCJDDFKMOF OHNLHFDAOKO()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, GOEBFDHHOGP>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6C239A0", Offset = "0x6C223A0", VA = "0x186C239A0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6C23A00", Offset = "0x6C22400", VA = "0x186C23A00")]
		public MutableOverridableObscuredFloat(bool AOFHMNBLLIM, ObscuredFloat KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6C238D0", Offset = "0x6C222D0", VA = "0x186C238D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6C23650", Offset = "0x6C22050", VA = "0x186C23650", Slot = "20")]
		public override void GFEKPLIEPFB(byte[] NANIBGLOJNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6C23720", Offset = "0x6C22120", VA = "0x186C23720", Slot = "19")]
		public override void IGBPCPFLJBG(GOEBFDHHOGP BHLHDOJEGCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6C237E0", Offset = "0x6C221E0", VA = "0x186C237E0", Slot = "18")]
		public override GOEBFDHHOGP OHNLHFDAOKO()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, CEJLGIIMCHG>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6C22870", Offset = "0x6C21270", VA = "0x186C22870")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6C235E0", Offset = "0x6C21FE0", VA = "0x186C235E0")]
		public MutableOverridableObscuredBool(bool AOFHMNBLLIM, ObscuredBool KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6C23510", Offset = "0x6C21F10", VA = "0x186C23510", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6C23200", Offset = "0x6C21C00", VA = "0x186C23200", Slot = "20")]
		public override void GFEKPLIEPFB(byte[] NANIBGLOJNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6C232D0", Offset = "0x6C21CD0", VA = "0x186C232D0", Slot = "19")]
		public override void IGBPCPFLJBG(CEJLGIIMCHG BHLHDOJEGCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6C23390", Offset = "0x6C21D90", VA = "0x186C23390", Slot = "18")]
		public override CEJLGIIMCHG OHNLHFDAOKO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6C23480", Offset = "0x6C21E80", VA = "0x186C23480", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, AIOFKIDIMGD<ObscuredBool>, NODJOJKLAKN<ObscuredBool>, CLDMJNFPMPI<ObscuredBool>, BPFKIBNMAMA
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x899870", Offset = "0x898270", VA = "0x180899870", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x899990", Offset = "0x898390", VA = "0x180899990", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6C22870", Offset = "0x6C21270", VA = "0x186C22870")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6C227F0", Offset = "0x6C211F0", VA = "0x186C227F0")]
		public void BGHBPLODFDC(MutableOverridableDefaultableObscuredBool PLNBHPCFEOK)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, KLCJDDFKMOF> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x4C19D20", Offset = "0x4C18720", VA = "0x184C19D20", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x4C19EC0", Offset = "0x4C188C0", VA = "0x184C19EC0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3A5B9B0", Offset = "0x3A5A3B0", VA = "0x183A5B9B0")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4C19CE0", Offset = "0x4C186E0", VA = "0x184C19CE0")]
		public SerializedMutableOverridableObscuredEnum(bool AOFHMNBLLIM, TObsEnum KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4C19BF0", Offset = "0x4C185F0", VA = "0x184C19BF0", Slot = "18")]
		public sealed override KLCJDDFKMOF OHNLHFDAOKO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4C19A70", Offset = "0x4C18470", VA = "0x184C19A70", Slot = "19")]
		public sealed override void IGBPCPFLJBG(KLCJDDFKMOF BHLHDOJEGCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4C19990", Offset = "0x4C18390", VA = "0x184C19990", Slot = "20")]
		public sealed override void GFEKPLIEPFB(byte[] NANIBGLOJNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4C19B70", Offset = "0x4C18570", VA = "0x184C19B70", Slot = "17")]
		public sealed override void LFBMALNLGLI()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, FBLAGBCCDNL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6C23130", Offset = "0x6C21B30", VA = "0x186C23130", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6C23170", Offset = "0x6C21B70", VA = "0x186C23170", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6C23090", Offset = "0x6C21A90", VA = "0x186C23090")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6C23030", Offset = "0x6C21A30", VA = "0x186C23030")]
		public MutableOverridableListObscuredString(bool AOFHMNBLLIM, List<ObscuredString> KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6C22F90", Offset = "0x6C21990", VA = "0x186C22F90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6C22D20", Offset = "0x6C21720", VA = "0x186C22D20", Slot = "17")]
		public override void LFBMALNLGLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6C228E0", Offset = "0x6C212E0", VA = "0x186C228E0", Slot = "20")]
		public override void GFEKPLIEPFB(byte[] NANIBGLOJNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6C229B0", Offset = "0x6C213B0", VA = "0x186C229B0", Slot = "19")]
		public override void IGBPCPFLJBG(FBLAGBCCDNL BHLHDOJEGCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6C22DB0", Offset = "0x6C217B0", VA = "0x186C22DB0", Slot = "18")]
		public override FBLAGBCCDNL OHNLHFDAOKO()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : CLDMJNFPMPI<Vector3>, BPFKIBNMAMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private Vector3 value;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9CA310", Offset = "0x9C8D10", VA = "0x1809CA310", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6C24090", Offset = "0x6C22A90", VA = "0x186C24090", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x44B4BD0", Offset = "0x44B35D0", VA = "0x1844B4BD0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x48C7D60", Offset = "0x48C6760", VA = "0x1848C7D60")]
		public OverridableVector3(Vector3 KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4EADAF0", Offset = "0x4EAC4F0", VA = "0x184EADAF0")]
		public OverridableVector3(bool AOFHMNBLLIM, Vector3 KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6C23FF0", Offset = "0x6C229F0", VA = "0x186C23FF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6C23FD0", Offset = "0x6C229D0", VA = "0x186C23FD0")]
		public static OverridableVector3 BIEOCAPMHCM(Vector3 AAJFAHDADNL)
		{
			return default(OverridableVector3);
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
