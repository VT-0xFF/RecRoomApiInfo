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
public interface OPHDOAHCIOL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DJLDHPKDNLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object BLDAKECEOEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PFABOFNEPHL<T> : OPHDOAHCIOL
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T KAMPPLLIEDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface CONHGLLKDFG<T> : PFABOFNEPHL<T>, OPHDOAHCIOL
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool DJLDHPKDNLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T KAMPPLLIEDO
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
public interface PGDGDAFLCIE<T> : CONHGLLKDFG<T>, PFABOFNEPHL<T>, OPHDOAHCIOL
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool DMCPOPKGOGD
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
	public struct OverridableInt : PFABOFNEPHL<int>, OPHDOAHCIOL
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
			[Cpp2IlInjected.Address(RVA = "0xDE7AC0", Offset = "0xDE6EC0", VA = "0x180DE7AC0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x75ACBF0", Offset = "0x75ABFF0", VA = "0x1875ACBF0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2BEE380", Offset = "0x2BED780", VA = "0x182BEE380", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x75ACB50", Offset = "0x75ABF50", VA = "0x1875ACB50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : PFABOFNEPHL<string>, OPHDOAHCIOL
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
			[Cpp2IlInjected.Address(RVA = "0xDE7AC0", Offset = "0xDE6EC0", VA = "0x180DE7AC0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xCA47E0", Offset = "0xCA3BE0", VA = "0x180CA47E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xCA47E0", Offset = "0xCA3BE0", VA = "0x180CA47E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x75ACC40", Offset = "0x75AC040", VA = "0x1875ACC40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : CONHGLLKDFG<InnerType>, PFABOFNEPHL<InnerType>, OPHDOAHCIOL where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool DJLDHPKDNLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType KAMPPLLIEDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object BLDAKECEOEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2791A20", Offset = "0x2790E20", VA = "0x182791A20", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4E6AF00", Offset = "0x4E6A300", VA = "0x184E6AF00")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4E6AF30", Offset = "0x4E6A330", VA = "0x184E6AF30")]
		public MutableOverridableBase(bool CBHKFCAHBMB, [NotNull] InnerType PEBNJNGMMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4E6A740", Offset = "0x4E69B40", VA = "0x184E6A740", Slot = "15")]
		public void CMLHFHIIBCN(PFABOFNEPHL<InnerType> NNDPIGFFLGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4E6AD00", Offset = "0x4E6A100", VA = "0x184E6AD00", Slot = "16")]
		public void PFNDDGDDDJB(PFABOFNEPHL<InnerType> MNALNBMKJLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4E6A930", Offset = "0x4E69D30", VA = "0x184E6A930", Slot = "17")]
		public virtual void HKGADJFONBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType IPMPOLOIDIL();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void KJJGMLLGDHE(ProtobufType KPNOLBFLFMD);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void JPFFNPDIKEP(byte[] NNDLOGCNOGG);
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
			[Cpp2IlInjected.Address(RVA = "0xB8D840", Offset = "0xB8CC40", VA = "0x180B8D840", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xB8D080", Offset = "0xB8C480", VA = "0x180B8D080", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xCD6AD0", Offset = "0xCD5ED0", VA = "0x180CD6AD0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x40B57F0", Offset = "0x40B4BF0", VA = "0x1840B57F0")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x52D0770", Offset = "0x52CFB70", VA = "0x1852D0770")]
		public SerializedMutableOverridableBase(bool CBHKFCAHBMB, InnerType PEBNJNGMMHE)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, PECBGMLCCFF>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x75ACA80", Offset = "0x75ABE80", VA = "0x1875ACA80")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x75ACAE0", Offset = "0x75ABEE0", VA = "0x1875ACAE0")]
		public MutableOverridableObscuredInt(bool CBHKFCAHBMB, ObscuredInt PEBNJNGMMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x75AC9B0", Offset = "0x75ABDB0", VA = "0x1875AC9B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x75AC830", Offset = "0x75ABC30", VA = "0x1875AC830", Slot = "20")]
		public override void JPFFNPDIKEP(byte[] NNDLOGCNOGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x75AC900", Offset = "0x75ABD00", VA = "0x1875AC900", Slot = "19")]
		public override void KJJGMLLGDHE(PECBGMLCCFF KPNOLBFLFMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x75AC750", Offset = "0x75ABB50", VA = "0x1875AC750", Slot = "18")]
		public override PECBGMLCCFF IPMPOLOIDIL()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, KDFGBCFNJNL>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x75AC680", Offset = "0x75ABA80", VA = "0x1875AC680")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x75AC6E0", Offset = "0x75ABAE0", VA = "0x1875AC6E0")]
		public MutableOverridableObscuredFloat(bool CBHKFCAHBMB, ObscuredFloat PEBNJNGMMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x75AC5B0", Offset = "0x75AB9B0", VA = "0x1875AC5B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x75AC420", Offset = "0x75AB820", VA = "0x1875AC420", Slot = "20")]
		public override void JPFFNPDIKEP(byte[] NNDLOGCNOGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x75AC4F0", Offset = "0x75AB8F0", VA = "0x1875AC4F0", Slot = "19")]
		public override void KJJGMLLGDHE(KDFGBCFNJNL KPNOLBFLFMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x75AC330", Offset = "0x75AB730", VA = "0x1875AC330", Slot = "18")]
		public override KDFGBCFNJNL IPMPOLOIDIL()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, PEDBNHOCMJI>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x75AB560", Offset = "0x75AA960", VA = "0x1875AB560")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x75AC2C0", Offset = "0x75AB6C0", VA = "0x1875AC2C0")]
		public MutableOverridableObscuredBool(bool CBHKFCAHBMB, ObscuredBool PEBNJNGMMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x75AC1F0", Offset = "0x75AB5F0", VA = "0x1875AC1F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x75ABFD0", Offset = "0x75AB3D0", VA = "0x1875ABFD0", Slot = "20")]
		public override void JPFFNPDIKEP(byte[] NNDLOGCNOGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x75AC0A0", Offset = "0x75AB4A0", VA = "0x1875AC0A0", Slot = "19")]
		public override void KJJGMLLGDHE(PEDBNHOCMJI KPNOLBFLFMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x75ABEE0", Offset = "0x75AB2E0", VA = "0x1875ABEE0", Slot = "18")]
		public override PEDBNHOCMJI IPMPOLOIDIL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x75AC160", Offset = "0x75AB560", VA = "0x1875AC160", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, PGDGDAFLCIE<ObscuredBool>, CONHGLLKDFG<ObscuredBool>, PFABOFNEPHL<ObscuredBool>, OPHDOAHCIOL
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x96A750", Offset = "0x969B50", VA = "0x18096A750", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x96A740", Offset = "0x969B40", VA = "0x18096A740", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x75AB560", Offset = "0x75AA960", VA = "0x1875AB560")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x75AB4E0", Offset = "0x75AA8E0", VA = "0x1875AB4E0")]
		public void CMLHFHIIBCN(MutableOverridableDefaultableObscuredBool MNALNBMKJLK)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, PECBGMLCCFF> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x52D0C00", Offset = "0x52D0000", VA = "0x1852D0C00", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x52D0D80", Offset = "0x52D0180", VA = "0x1852D0D80", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4628820", Offset = "0x4627C20", VA = "0x184628820")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x52D0BC0", Offset = "0x52CFFC0", VA = "0x1852D0BC0")]
		public SerializedMutableOverridableObscuredEnum(bool CBHKFCAHBMB, TObsEnum PEBNJNGMMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x52D08F0", Offset = "0x52CFCF0", VA = "0x1852D08F0", Slot = "18")]
		public sealed override PECBGMLCCFF IPMPOLOIDIL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x52D0AC0", Offset = "0x52CFEC0", VA = "0x1852D0AC0", Slot = "19")]
		public sealed override void KJJGMLLGDHE(PECBGMLCCFF KPNOLBFLFMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x52D09E0", Offset = "0x52CFDE0", VA = "0x1852D09E0", Slot = "20")]
		public sealed override void JPFFNPDIKEP(byte[] NNDLOGCNOGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x52D0870", Offset = "0x52CFC70", VA = "0x1852D0870", Slot = "17")]
		public sealed override void HKGADJFONBN()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, JNAPOMJODMN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x75ABE10", Offset = "0x75AB210", VA = "0x1875ABE10", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x75ABE50", Offset = "0x75AB250", VA = "0x1875ABE50", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x75ABD70", Offset = "0x75AB170", VA = "0x1875ABD70")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x75ABD10", Offset = "0x75AB110", VA = "0x1875ABD10")]
		public MutableOverridableListObscuredString(bool CBHKFCAHBMB, List<ObscuredString> PEBNJNGMMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x75ABC70", Offset = "0x75AB070", VA = "0x1875ABC70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x75AB5D0", Offset = "0x75AA9D0", VA = "0x1875AB5D0", Slot = "17")]
		public override void HKGADJFONBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x75AB840", Offset = "0x75AAC40", VA = "0x1875AB840", Slot = "20")]
		public override void JPFFNPDIKEP(byte[] NNDLOGCNOGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x75AB910", Offset = "0x75AAD10", VA = "0x1875AB910", Slot = "19")]
		public override void KJJGMLLGDHE(JNAPOMJODMN KPNOLBFLFMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x75AB660", Offset = "0x75AAA60", VA = "0x1875AB660", Slot = "18")]
		public override JNAPOMJODMN IPMPOLOIDIL()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : PFABOFNEPHL<Vector3>, OPHDOAHCIOL
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
			[Cpp2IlInjected.Address(RVA = "0xDE7AC0", Offset = "0xDE6EC0", VA = "0x180DE7AC0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x75ACD70", Offset = "0x75AC170", VA = "0x1875ACD70", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x4BC4470", Offset = "0x4BC3870", VA = "0x184BC4470", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4F719D0", Offset = "0x4F70DD0", VA = "0x184F719D0")]
		public OverridableVector3(Vector3 PEBNJNGMMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x55ADEB0", Offset = "0x55AD2B0", VA = "0x1855ADEB0")]
		public OverridableVector3(bool CBHKFCAHBMB, Vector3 PEBNJNGMMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x75ACCD0", Offset = "0x75AC0D0", VA = "0x1875ACCD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x75ACCB0", Offset = "0x75AC0B0", VA = "0x1875ACCB0")]
		public static OverridableVector3 JKGHIELMIOO(Vector3 GHFLHNCPIIL)
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
