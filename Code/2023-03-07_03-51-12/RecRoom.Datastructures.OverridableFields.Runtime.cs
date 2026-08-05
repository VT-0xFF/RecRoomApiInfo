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
public interface JOKKAEJKAED
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool OCEJGOPPOEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object CMEGHCIJODO
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HKKHCFCGKPC<T> : JOKKAEJKAED
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T EJBPMDLBLGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KFMLEBHBKPN<T> : global::HKKHCFCGKPC<T>, JOKKAEJKAED
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool OCEJGOPPOEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T EJBPMDLBLGL
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
public interface IDFNCJKLKNH<T> : global::KFMLEBHBKPN<T>, global::HKKHCFCGKPC<T>, JOKKAEJKAED
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool ALKFIJFIEPP
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
	public struct OverridableInt : global::HKKHCFCGKPC<int>, JOKKAEJKAED
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
			[Cpp2IlInjected.Address(RVA = "0x9E4070", Offset = "0x9E3470", VA = "0x1809E4070", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x1A3FB30", Offset = "0x1A3EF30", VA = "0x181A3FB30", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x829550", Offset = "0x828950", VA = "0x180829550", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1A3FA90", Offset = "0x1A3EE90", VA = "0x181A3FA90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : global::HKKHCFCGKPC<string>, JOKKAEJKAED
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
			[Cpp2IlInjected.Address(RVA = "0x9E4070", Offset = "0x9E3470", VA = "0x1809E4070", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x780910", Offset = "0x77FD10", VA = "0x180780910", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x780910", Offset = "0x77FD10", VA = "0x180780910", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1A3FB80", Offset = "0x1A3EF80", VA = "0x181A3FB80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : global::KFMLEBHBKPN<InnerType>, global::HKKHCFCGKPC<InnerType>, JOKKAEJKAED where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool OCEJGOPPOEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType EJBPMDLBLGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object CMEGHCIJODO
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x32EB6D0", Offset = "0x32EAAD0", VA = "0x1832EB6D0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3629FD0", Offset = "0x36293D0", VA = "0x183629FD0")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x362A090", Offset = "0x3629490", VA = "0x18362A090")]
		public MutableOverridableBase(bool KCOFDHIDLIM, [NotNull] InnerType FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3629800", Offset = "0x3628C00", VA = "0x183629800", Slot = "15")]
		public void ICAGPGMILPE(global::HKKHCFCGKPC<InnerType> GBCCIJLEABL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3629A10", Offset = "0x3628E10", VA = "0x183629A10", Slot = "16")]
		public void JOLBHMNFBGF(global::HKKHCFCGKPC<InnerType> FJLHJLAMLMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3629D60", Offset = "0x3629160", VA = "0x183629D60", Slot = "17")]
		public virtual void LMINFOAGFJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType JFMHFLIDEMG();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void OEKMMKHIACP(ProtobufType IPFFBCILDPE);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void CNICPLIHBEN(byte[] DFKCEAIAOPL);
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
			[Cpp2IlInjected.Address(RVA = "0x826290", Offset = "0x825690", VA = "0x180826290", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8262B0", Offset = "0x8256B0", VA = "0x1808262B0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x24CE890", Offset = "0x24CDC90", VA = "0x1824CE890", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x21AEE40", Offset = "0x21AE240", VA = "0x1821AEE40")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x371CF00", Offset = "0x371C300", VA = "0x18371CF00")]
		public SerializedMutableOverridableBase(bool KCOFDHIDLIM, InnerType FPLJCBGEJAP)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, BEKBCFGBNAK>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1A3FA30", Offset = "0x1A3EE30", VA = "0x181A3FA30")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1A3F9C0", Offset = "0x1A3EDC0", VA = "0x181A3F9C0")]
		public MutableOverridableObscuredInt(bool KCOFDHIDLIM, ObscuredInt FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1A3F8F0", Offset = "0x1A3ECF0", VA = "0x181A3F8F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1A3F650", Offset = "0x1A3EA50", VA = "0x181A3F650", Slot = "20")]
		public override void CNICPLIHBEN(byte[] DFKCEAIAOPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1A3F830", Offset = "0x1A3EC30", VA = "0x181A3F830", Slot = "19")]
		public override void OEKMMKHIACP(BEKBCFGBNAK IPFFBCILDPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1A3F750", Offset = "0x1A3EB50", VA = "0x181A3F750", Slot = "18")]
		public override BEKBCFGBNAK JFMHFLIDEMG()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, CLPAEKOOJDL>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x1A3F580", Offset = "0x1A3E980", VA = "0x181A3F580")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1A3F5E0", Offset = "0x1A3E9E0", VA = "0x181A3F5E0")]
		public MutableOverridableObscuredFloat(bool KCOFDHIDLIM, ObscuredFloat FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1A3F4B0", Offset = "0x1A3E8B0", VA = "0x181A3F4B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1A3F1F0", Offset = "0x1A3E5F0", VA = "0x181A3F1F0", Slot = "20")]
		public override void CNICPLIHBEN(byte[] DFKCEAIAOPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1A3F3E0", Offset = "0x1A3E7E0", VA = "0x181A3F3E0", Slot = "19")]
		public override void OEKMMKHIACP(CLPAEKOOJDL IPFFBCILDPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1A3F2F0", Offset = "0x1A3E6F0", VA = "0x181A3F2F0", Slot = "18")]
		public override CLPAEKOOJDL JFMHFLIDEMG()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, MENPKLNCHDP>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1A3E4B0", Offset = "0x1A3D8B0", VA = "0x181A3E4B0")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1A3F180", Offset = "0x1A3E580", VA = "0x181A3F180")]
		public MutableOverridableObscuredBool(bool KCOFDHIDLIM, ObscuredBool FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1A3F0B0", Offset = "0x1A3E4B0", VA = "0x181A3F0B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1A3EDD0", Offset = "0x1A3E1D0", VA = "0x181A3EDD0", Slot = "20")]
		public override void CNICPLIHBEN(byte[] DFKCEAIAOPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1A3EFB0", Offset = "0x1A3E3B0", VA = "0x181A3EFB0", Slot = "19")]
		public override void OEKMMKHIACP(MENPKLNCHDP IPFFBCILDPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1A3EED0", Offset = "0x1A3E2D0", VA = "0x181A3EED0", Slot = "18")]
		public override MENPKLNCHDP JFMHFLIDEMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1A3F070", Offset = "0x1A3E470", VA = "0x181A3F070", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, global::IDFNCJKLKNH<ObscuredBool>, global::KFMLEBHBKPN<ObscuredBool>, global::HKKHCFCGKPC<ObscuredBool>, JOKKAEJKAED
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x91B8C0", Offset = "0x91ACC0", VA = "0x18091B8C0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAACD20", Offset = "0xAAC120", VA = "0x180AACD20", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1A3E4B0", Offset = "0x1A3D8B0", VA = "0x181A3E4B0")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1A3E430", Offset = "0x1A3D830", VA = "0x181A3E430")]
		public void ICAGPGMILPE(MutableOverridableDefaultableObscuredBool FJLHJLAMLMA)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, BEKBCFGBNAK> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x39712E0", Offset = "0x39706E0", VA = "0x1839712E0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x39713C0", Offset = "0x39707C0", VA = "0x1839713C0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2C13940", Offset = "0x2C12D40", VA = "0x182C13940")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x39712B0", Offset = "0x39706B0", VA = "0x1839712B0")]
		public SerializedMutableOverridableObscuredEnum(TObsEnum FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3971280", Offset = "0x3970680", VA = "0x183971280")]
		public SerializedMutableOverridableObscuredEnum(bool KCOFDHIDLIM, TObsEnum FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3971060", Offset = "0x3970460", VA = "0x183971060", Slot = "18")]
		public sealed override BEKBCFGBNAK JFMHFLIDEMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3971170", Offset = "0x3970570", VA = "0x183971170", Slot = "19")]
		public sealed override void OEKMMKHIACP(BEKBCFGBNAK IPFFBCILDPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3970F60", Offset = "0x3970360", VA = "0x183970F60", Slot = "20")]
		public sealed override void CNICPLIHBEN(byte[] DFKCEAIAOPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3971110", Offset = "0x3970510", VA = "0x183971110", Slot = "17")]
		public sealed override void LMINFOAGFJI()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, FDAJPHINPNN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x1A3ED00", Offset = "0x1A3E100", VA = "0x181A3ED00", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x1A3ED40", Offset = "0x1A3E140", VA = "0x181A3ED40", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1A3EC10", Offset = "0x1A3E010", VA = "0x181A3EC10")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1A3ECA0", Offset = "0x1A3E0A0", VA = "0x181A3ECA0")]
		public MutableOverridableListObscuredString(bool KCOFDHIDLIM, List<ObscuredString> FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x1A3EB70", Offset = "0x1A3DF70", VA = "0x181A3EB70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1A3E7E0", Offset = "0x1A3DBE0", VA = "0x181A3E7E0", Slot = "17")]
		public override void LMINFOAGFJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1A3E520", Offset = "0x1A3D920", VA = "0x181A3E520", Slot = "20")]
		public override void CNICPLIHBEN(byte[] DFKCEAIAOPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1A3E850", Offset = "0x1A3DC50", VA = "0x181A3E850", Slot = "19")]
		public override void OEKMMKHIACP(FDAJPHINPNN IPFFBCILDPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1A3E620", Offset = "0x1A3DA20", VA = "0x181A3E620", Slot = "18")]
		public override FDAJPHINPNN JFMHFLIDEMG()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : global::HKKHCFCGKPC<Vector3>, JOKKAEJKAED
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
			[Cpp2IlInjected.Address(RVA = "0x9E4070", Offset = "0x9E3470", VA = "0x1809E4070", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x1A3FCD0", Offset = "0x1A3F0D0", VA = "0x181A3FCD0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7EFB00", Offset = "0x7EEF00", VA = "0x1807EFB00", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x1A3FCB0", Offset = "0x1A3F0B0", VA = "0x181A3FCB0")]
		public OverridableVector3(Vector3 FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x1A3FC10", Offset = "0x1A3F010", VA = "0x181A3FC10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1A3FBF0", Offset = "0x1A3EFF0", VA = "0x181A3FBF0")]
		public static OverridableVector3 ABLJGBEPCFM(Vector3 MMHJJFKDNDC)
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
