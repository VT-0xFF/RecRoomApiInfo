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
public interface FIGOCOFCOBP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool AFNFEBHHMDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object CFJKADLIFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DCGPCEHKFDH<T> : FIGOCOFCOBP
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T NDNOLKCBONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LGMFKOANLOF<T> : global::DCGPCEHKFDH<T>, FIGOCOFCOBP
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool AFNFEBHHMDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T NDNOLKCBONM
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
public interface FMAAGMJGCEP<T> : global::LGMFKOANLOF<T>, global::DCGPCEHKFDH<T>, FIGOCOFCOBP
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool NKEHDCHKABP
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
	public struct OverridableInt : global::DCGPCEHKFDH<int>, FIGOCOFCOBP
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
			[Cpp2IlInjected.Address(RVA = "0x9C3440", Offset = "0x9C2840", VA = "0x1809C3440", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6A1E240", Offset = "0x6A1D640", VA = "0x186A1E240", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x899ED0", Offset = "0x8992D0", VA = "0x180899ED0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6A1E1A0", Offset = "0x6A1D5A0", VA = "0x186A1E1A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : global::DCGPCEHKFDH<string>, FIGOCOFCOBP
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
			[Cpp2IlInjected.Address(RVA = "0x9C3440", Offset = "0x9C2840", VA = "0x1809C3440", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x979860", Offset = "0x978C60", VA = "0x180979860", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x979860", Offset = "0x978C60", VA = "0x180979860", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6A1E290", Offset = "0x6A1D690", VA = "0x186A1E290", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : global::LGMFKOANLOF<InnerType>, global::DCGPCEHKFDH<InnerType>, FIGOCOFCOBP where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool AFNFEBHHMDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType NDNOLKCBONM
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object CFJKADLIFMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x21FDF20", Offset = "0x21FD320", VA = "0x1821FDF20", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x21FDC90", Offset = "0x21FD090", VA = "0x1821FDC90")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x21FDD50", Offset = "0x21FD150", VA = "0x1821FDD50")]
		public MutableOverridableBase(bool NCKOBMCKFDE, [NotNull] InnerType LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x21FDAC0", Offset = "0x21FCEC0", VA = "0x1821FDAC0", Slot = "15")]
		public void MNLIHOGNBPH(global::DCGPCEHKFDH<InnerType> KPDKPCHGMJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x21FD730", Offset = "0x21FCB30", VA = "0x1821FD730", Slot = "16")]
		public void MLOEOOCDIIH(global::DCGPCEHKFDH<InnerType> MPHACEGLFIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x21FD250", Offset = "0x21FC650", VA = "0x1821FD250", Slot = "17")]
		public virtual void JAIKDMLJCNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType AHMGOBHNBEG();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void HDFOBCICHPI(ProtobufType GELIMIHGABP);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void AJJFMACIMCM(byte[] BDCJONFOPDP);
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
			[Cpp2IlInjected.Address(RVA = "0x7B1910", Offset = "0x7B0D10", VA = "0x1807B1910", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7B1940", Offset = "0x7B0D40", VA = "0x1807B1940", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x170F2E0", Offset = "0x170E6E0", VA = "0x18170F2E0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1379D50", Offset = "0x1379150", VA = "0x181379D50")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3251B20", Offset = "0x3250F20", VA = "0x183251B20")]
		public SerializedMutableOverridableBase(bool NCKOBMCKFDE, InnerType LPJDDLMPNCG)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, OCCDJCLABNK>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6A1E140", Offset = "0x6A1D540", VA = "0x186A1E140")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6A1E0D0", Offset = "0x6A1D4D0", VA = "0x186A1E0D0")]
		public MutableOverridableObscuredInt(bool NCKOBMCKFDE, ObscuredInt LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6A1E000", Offset = "0x6A1D400", VA = "0x186A1E000", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6A1DE40", Offset = "0x6A1D240", VA = "0x186A1DE40", Slot = "20")]
		public override void AJJFMACIMCM(byte[] BDCJONFOPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6A1DF40", Offset = "0x6A1D340", VA = "0x186A1DF40", Slot = "19")]
		public override void HDFOBCICHPI(OCCDJCLABNK GELIMIHGABP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6A1DD60", Offset = "0x6A1D160", VA = "0x186A1DD60", Slot = "18")]
		public override OCCDJCLABNK AHMGOBHNBEG()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, HDKKODBDPHP>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6A1DC90", Offset = "0x6A1D090", VA = "0x186A1DC90")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6A1DCF0", Offset = "0x6A1D0F0", VA = "0x186A1DCF0")]
		public MutableOverridableObscuredFloat(bool NCKOBMCKFDE, ObscuredFloat LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6A1DBC0", Offset = "0x6A1CFC0", VA = "0x186A1DBC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6A1D9F0", Offset = "0x6A1CDF0", VA = "0x186A1D9F0", Slot = "20")]
		public override void AJJFMACIMCM(byte[] BDCJONFOPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6A1DAF0", Offset = "0x6A1CEF0", VA = "0x186A1DAF0", Slot = "19")]
		public override void HDFOBCICHPI(HDKKODBDPHP GELIMIHGABP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6A1D900", Offset = "0x6A1CD00", VA = "0x186A1D900", Slot = "18")]
		public override HDKKODBDPHP AHMGOBHNBEG()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, HDOKKMJKLLA>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6A1CBC0", Offset = "0x6A1BFC0", VA = "0x186A1CBC0")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6A1D890", Offset = "0x6A1CC90", VA = "0x186A1D890")]
		public MutableOverridableObscuredBool(bool NCKOBMCKFDE, ObscuredBool LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6A1D7C0", Offset = "0x6A1CBC0", VA = "0x186A1D7C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6A1D5C0", Offset = "0x6A1C9C0", VA = "0x186A1D5C0", Slot = "20")]
		public override void AJJFMACIMCM(byte[] BDCJONFOPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6A1D6C0", Offset = "0x6A1CAC0", VA = "0x186A1D6C0", Slot = "19")]
		public override void HDFOBCICHPI(HDOKKMJKLLA GELIMIHGABP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6A1D4E0", Offset = "0x6A1C8E0", VA = "0x186A1D4E0", Slot = "18")]
		public override HDOKKMJKLLA AHMGOBHNBEG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6A1D780", Offset = "0x6A1CB80", VA = "0x186A1D780", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, global::FMAAGMJGCEP<ObscuredBool>, global::LGMFKOANLOF<ObscuredBool>, global::DCGPCEHKFDH<ObscuredBool>, FIGOCOFCOBP
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x72FD70", Offset = "0x72F170", VA = "0x18072FD70", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x753E00", Offset = "0x753200", VA = "0x180753E00", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6A1CBC0", Offset = "0x6A1BFC0", VA = "0x186A1CBC0")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6A1CB40", Offset = "0x6A1BF40", VA = "0x186A1CB40")]
		public void MNLIHOGNBPH(MutableOverridableDefaultableObscuredBool MPHACEGLFIL)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, OCCDJCLABNK> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x3794000", Offset = "0x3793400", VA = "0x183794000", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x37940E0", Offset = "0x37934E0", VA = "0x1837940E0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x20AF8D0", Offset = "0x20AECD0", VA = "0x1820AF8D0")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3793FD0", Offset = "0x37933D0", VA = "0x183793FD0")]
		public SerializedMutableOverridableObscuredEnum(TObsEnum LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3251AF0", Offset = "0x3250EF0", VA = "0x183251AF0")]
		public SerializedMutableOverridableObscuredEnum(bool NCKOBMCKFDE, TObsEnum LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3793CB0", Offset = "0x37930B0", VA = "0x183793CB0", Slot = "18")]
		public sealed override OCCDJCLABNK AHMGOBHNBEG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3793E60", Offset = "0x3793260", VA = "0x183793E60", Slot = "19")]
		public sealed override void HDFOBCICHPI(OCCDJCLABNK GELIMIHGABP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3793D60", Offset = "0x3793160", VA = "0x183793D60", Slot = "20")]
		public sealed override void AJJFMACIMCM(byte[] BDCJONFOPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3793F70", Offset = "0x3793370", VA = "0x183793F70", Slot = "17")]
		public sealed override void JAIKDMLJCNA()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, BGAKMLFJOKG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6A1D410", Offset = "0x6A1C810", VA = "0x186A1D410", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6A1D450", Offset = "0x6A1C850", VA = "0x186A1D450", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6A1D320", Offset = "0x6A1C720", VA = "0x186A1D320")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6A1D3B0", Offset = "0x6A1C7B0", VA = "0x186A1D3B0")]
		public MutableOverridableListObscuredString(bool NCKOBMCKFDE, List<ObscuredString> LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6A1D280", Offset = "0x6A1C680", VA = "0x186A1D280", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6A1D210", Offset = "0x6A1C610", VA = "0x186A1D210", Slot = "17")]
		public override void JAIKDMLJCNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6A1CDF0", Offset = "0x6A1C1F0", VA = "0x186A1CDF0", Slot = "20")]
		public override void AJJFMACIMCM(byte[] BDCJONFOPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6A1CEF0", Offset = "0x6A1C2F0", VA = "0x186A1CEF0", Slot = "19")]
		public override void HDFOBCICHPI(BGAKMLFJOKG GELIMIHGABP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6A1CC30", Offset = "0x6A1C030", VA = "0x186A1CC30", Slot = "18")]
		public override BGAKMLFJOKG AHMGOBHNBEG()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : global::DCGPCEHKFDH<Vector3>, FIGOCOFCOBP
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
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x9C3440", Offset = "0x9C2840", VA = "0x1809C3440", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6A1E3E0", Offset = "0x6A1D7E0", VA = "0x186A1E3E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x1D05F90", Offset = "0x1D05390", VA = "0x181D05F90", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6A1E3C0", Offset = "0x6A1D7C0", VA = "0x186A1E3C0")]
		public OverridableVector3(Vector3 LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6A1E320", Offset = "0x6A1D720", VA = "0x186A1E320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6A1E300", Offset = "0x6A1D700", VA = "0x186A1E300")]
		public static OverridableVector3 HPHCHABBDNG(Vector3 IHADMCKJLJA)
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
