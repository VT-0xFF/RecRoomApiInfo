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
public interface DFNMFACPIAG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MHDEPLJNGEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object OHLJMKCKOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DCCOCLDPAKP<T> : DFNMFACPIAG
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T EJFMLMNCFJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface NJKLBNMGGKC<T> : global::DCCOCLDPAKP<T>, DFNMFACPIAG
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool MHDEPLJNGEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T EJFMLMNCFJG
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
public interface AGPFPBCJOKH<T> : global::NJKLBNMGGKC<T>, global::DCCOCLDPAKP<T>, DFNMFACPIAG
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool PFNBMHDOMGD
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
	public struct OverridableInt : global::DCCOCLDPAKP<int>, DFNMFACPIAG
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
			[Cpp2IlInjected.Address(RVA = "0xECE460", Offset = "0xECCC60", VA = "0x180ECE460", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x41EC170", Offset = "0x41EA970", VA = "0x1841EC170", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xECE690", Offset = "0xECCE90", VA = "0x180ECE690", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x41EC0F0", Offset = "0x41EA8F0", VA = "0x1841EC0F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : global::DCCOCLDPAKP<string>, DFNMFACPIAG
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
			[Cpp2IlInjected.Address(RVA = "0xECE460", Offset = "0xECCC60", VA = "0x180ECE460", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6DA250", Offset = "0x6D8A50", VA = "0x1806DA250", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6DA250", Offset = "0x6D8A50", VA = "0x1806DA250", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x41EC1C0", Offset = "0x41EA9C0", VA = "0x1841EC1C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : global::NJKLBNMGGKC<InnerType>, global::DCCOCLDPAKP<InnerType>, DFNMFACPIAG where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool MHDEPLJNGEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType EJFMLMNCFJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object OHLJMKCKOBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x1200640", Offset = "0x11FEE40", VA = "0x181200640", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1200420", Offset = "0x11FEC20", VA = "0x181200420")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x12004D0", Offset = "0x11FECD0", VA = "0x1812004D0")]
		public MutableOverridableBase(bool NFMLJICIIEE, [NotNull] InnerType CJMMBFLIBMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x11FFEC0", Offset = "0x11FE6C0", VA = "0x1811FFEC0", Slot = "15")]
		public void JKKDHHADKPB(global::DCCOCLDPAKP<InnerType> JLLEGNBJLLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x11FF8F0", Offset = "0x11FE0F0", VA = "0x1811FF8F0", Slot = "16")]
		public void GBMPOEGKMCI(global::DCCOCLDPAKP<InnerType> ALBOAABJIJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1200280", Offset = "0x11FEA80", VA = "0x181200280", Slot = "17")]
		public virtual void LCAEFMHIJAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType NOLEFEODNNH();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void GODLFOLFKOD(ProtobufType PAFKHPBFLEL);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void OHHJEHACLHP(byte[] IGIALEKFDPH);
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
			[Cpp2IlInjected.Address(RVA = "0x6358A0", Offset = "0x6340A0", VA = "0x1806358A0", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6866D0", Offset = "0x684ED0", VA = "0x1806866D0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1209000", Offset = "0x1207800", VA = "0x181209000", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x11F76D0", Offset = "0x11F5ED0", VA = "0x1811F76D0")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1208F50", Offset = "0x1207750", VA = "0x181208F50")]
		public SerializedMutableOverridableBase(bool NFMLJICIIEE, InnerType CJMMBFLIBMO)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, ODOFMIAKALF>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x41EC080", Offset = "0x41EA880", VA = "0x1841EC080")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x41EC010", Offset = "0x41EA810", VA = "0x1841EC010")]
		public MutableOverridableObscuredInt(bool NFMLJICIIEE, ObscuredInt CJMMBFLIBMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x41EBF60", Offset = "0x41EA760", VA = "0x1841EBF60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x41EBE70", Offset = "0x41EA670", VA = "0x1841EBE70", Slot = "20")]
		public override void OHHJEHACLHP(byte[] IGIALEKFDPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x41EBCE0", Offset = "0x41EA4E0", VA = "0x1841EBCE0", Slot = "19")]
		public override void GODLFOLFKOD(ODOFMIAKALF PAFKHPBFLEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x41EBDA0", Offset = "0x41EA5A0", VA = "0x1841EBDA0", Slot = "18")]
		public override ODOFMIAKALF NOLEFEODNNH()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, BCLMAJNHAJD>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x41EBC00", Offset = "0x41EA400", VA = "0x1841EBC00")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x41EBC70", Offset = "0x41EA470", VA = "0x1841EBC70")]
		public MutableOverridableObscuredFloat(bool NFMLJICIIEE, ObscuredFloat CJMMBFLIBMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x41EBB50", Offset = "0x41EA350", VA = "0x1841EBB50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x41EBA60", Offset = "0x41EA260", VA = "0x1841EBA60", Slot = "20")]
		public override void OHHJEHACLHP(byte[] IGIALEKFDPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x41EB8B0", Offset = "0x41EA0B0", VA = "0x1841EB8B0", Slot = "19")]
		public override void GODLFOLFKOD(BCLMAJNHAJD PAFKHPBFLEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x41EB980", Offset = "0x41EA180", VA = "0x1841EB980", Slot = "18")]
		public override BCLMAJNHAJD NOLEFEODNNH()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, IKLOLKNHBKF>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x41EAC70", Offset = "0x41E9470", VA = "0x1841EAC70")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x41EB840", Offset = "0x41EA040", VA = "0x1841EB840")]
		public MutableOverridableObscuredBool(bool NFMLJICIIEE, ObscuredBool CJMMBFLIBMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x41EB790", Offset = "0x41E9F90", VA = "0x1841EB790", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x41EB6A0", Offset = "0x41E9EA0", VA = "0x1841EB6A0", Slot = "20")]
		public override void OHHJEHACLHP(byte[] IGIALEKFDPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x41EB500", Offset = "0x41E9D00", VA = "0x1841EB500", Slot = "19")]
		public override void GODLFOLFKOD(IKLOLKNHBKF PAFKHPBFLEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x41EB5C0", Offset = "0x41E9DC0", VA = "0x1841EB5C0", Slot = "18")]
		public override IKLOLKNHBKF NOLEFEODNNH()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, global::AGPFPBCJOKH<ObscuredBool>, global::NJKLBNMGGKC<ObscuredBool>, global::DCCOCLDPAKP<ObscuredBool>, DFNMFACPIAG
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5F6F80", Offset = "0x5F5780", VA = "0x1805F6F80", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x5F6F70", Offset = "0x5F5770", VA = "0x1805F6F70", Slot = "22")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x41EAC70", Offset = "0x41E9470", VA = "0x1841EAC70")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x41EABF0", Offset = "0x41E93F0", VA = "0x1841EABF0")]
		public void JKKDHHADKPB(MutableOverridableDefaultableObscuredBool ALBOAABJIJF)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, ODOFMIAKALF> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x12093E0", Offset = "0x1207BE0", VA = "0x1812093E0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x12094C0", Offset = "0x1207CC0", VA = "0x1812094C0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xB7D710", Offset = "0xB7BF10", VA = "0x180B7D710")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x12093B0", Offset = "0x1207BB0", VA = "0x1812093B0")]
		public SerializedMutableOverridableObscuredEnum(TObsEnum CJMMBFLIBMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1209380", Offset = "0x1207B80", VA = "0x181209380")]
		public SerializedMutableOverridableObscuredEnum(bool NFMLJICIIEE, TObsEnum CJMMBFLIBMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x12091D0", Offset = "0x12079D0", VA = "0x1812091D0", Slot = "18")]
		public sealed override ODOFMIAKALF NOLEFEODNNH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1209060", Offset = "0x1207860", VA = "0x181209060", Slot = "19")]
		public sealed override void GODLFOLFKOD(ODOFMIAKALF PAFKHPBFLEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1209290", Offset = "0x1207A90", VA = "0x181209290", Slot = "20")]
		public sealed override void OHHJEHACLHP(byte[] IGIALEKFDPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1209170", Offset = "0x1207970", VA = "0x181209170", Slot = "17")]
		public sealed override void LCAEFMHIJAM()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, MAJINAGFLDF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x41EB450", Offset = "0x41E9C50", VA = "0x1841EB450", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x41EB490", Offset = "0x41E9C90", VA = "0x1841EB490", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x41EB3D0", Offset = "0x41E9BD0", VA = "0x1841EB3D0")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x41EB370", Offset = "0x41E9B70", VA = "0x1841EB370")]
		public MutableOverridableListObscuredString(bool NFMLJICIIEE, List<ObscuredString> CJMMBFLIBMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x41EB2E0", Offset = "0x41E9AE0", VA = "0x1841EB2E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x41EAFD0", Offset = "0x41E97D0", VA = "0x1841EAFD0", Slot = "17")]
		public override void LCAEFMHIJAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x41EB1F0", Offset = "0x41E99F0", VA = "0x1841EB1F0", Slot = "20")]
		public override void OHHJEHACLHP(byte[] IGIALEKFDPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x41EACD0", Offset = "0x41E94D0", VA = "0x1841EACD0", Slot = "19")]
		public override void GODLFOLFKOD(MAJINAGFLDF PAFKHPBFLEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x41EB040", Offset = "0x41E9840", VA = "0x1841EB040", Slot = "18")]
		public override MAJINAGFLDF NOLEFEODNNH()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : global::DCCOCLDPAKP<Vector3>, DFNMFACPIAG
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
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xECE460", Offset = "0xECCC60", VA = "0x180ECE460", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x41EC2F0", Offset = "0x41EAAF0", VA = "0x1841EC2F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x2910560", Offset = "0x290ED60", VA = "0x182910560", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x41EC2D0", Offset = "0x41EAAD0", VA = "0x1841EC2D0")]
		public OverridableVector3(Vector3 CJMMBFLIBMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x41EC240", Offset = "0x41EAA40", VA = "0x1841EC240", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x41EC220", Offset = "0x41EAA20", VA = "0x1841EC220")]
		public static OverridableVector3 HLHIMDAEEEO(Vector3 OKHMGJIMEEL)
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
