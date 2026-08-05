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
public interface KPMPHCAIFHG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool LHFHOBOKAAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object JMFDFPAOEEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IIPHBKJKPKI<T> : KPMPHCAIFHG
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T ECFALLCDCAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface IBOMCFBLIHM<T> : global::IIPHBKJKPKI<T>, KPMPHCAIFHG
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool LHFHOBOKAAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T ECFALLCDCAA
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
public interface OLCMOHGHOMD<T> : global::IBOMCFBLIHM<T>, global::IIPHBKJKPKI<T>, KPMPHCAIFHG
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool BCEJFOFMKCJ
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
	public struct OverridableInt : global::IIPHBKJKPKI<int>, KPMPHCAIFHG
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
			[Cpp2IlInjected.Address(RVA = "0x8D3330", Offset = "0x8D2730", VA = "0x1808D3330", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5FF2EC0", Offset = "0x5FF22C0", VA = "0x185FF2EC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8ABB60", Offset = "0x8AAF60", VA = "0x1808ABB60", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2E20", Offset = "0x5FF2220", VA = "0x185FF2E20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : global::IIPHBKJKPKI<string>, KPMPHCAIFHG
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
			[Cpp2IlInjected.Address(RVA = "0x8D3330", Offset = "0x8D2730", VA = "0x1808D3330", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6C3B00", Offset = "0x6C2F00", VA = "0x1806C3B00", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6C3B00", Offset = "0x6C2F00", VA = "0x1806C3B00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2F10", Offset = "0x5FF2310", VA = "0x185FF2F10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : global::IBOMCFBLIHM<InnerType>, global::IIPHBKJKPKI<InnerType>, KPMPHCAIFHG where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool LHFHOBOKAAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType ECFALLCDCAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object JMFDFPAOEEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2737B30", Offset = "0x2736F30", VA = "0x182737B30", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x27378A0", Offset = "0x2736CA0", VA = "0x1827378A0")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2737960", Offset = "0x2736D60", VA = "0x182737960")]
		public MutableOverridableBase(bool GNBAFAOHAEE, [NotNull] InnerType PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2736F80", Offset = "0x2736380", VA = "0x182736F80", Slot = "15")]
		public void IDBECLNIPFO(global::IIPHBKJKPKI<InnerType> ECALKLECCIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2737310", Offset = "0x2736710", VA = "0x182737310", Slot = "16")]
		public void IHGJCBOPEIC(global::IIPHBKJKPKI<InnerType> BKBGGIICJOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2736E10", Offset = "0x2736210", VA = "0x182736E10", Slot = "17")]
		public virtual void ACEKBINJHGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType MBMFDGMCFKN();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void LGIIKINAFJF(ProtobufType FOLBNLFCLOC);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void MDOAMNMJALM(byte[] KLHEEAOCGIE);
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
			[Cpp2IlInjected.Address(RVA = "0x671250", Offset = "0x670650", VA = "0x180671250", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x671270", Offset = "0x670670", VA = "0x180671270", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xF99CA0", Offset = "0xF990A0", VA = "0x180F99CA0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1125B70", Offset = "0x1124F70", VA = "0x181125B70")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x231CBA0", Offset = "0x231BFA0", VA = "0x18231CBA0")]
		public SerializedMutableOverridableBase(bool GNBAFAOHAEE, InnerType PKODKJLGOIN)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, DOKLNDCHENH>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2DC0", Offset = "0x5FF21C0", VA = "0x185FF2DC0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2D50", Offset = "0x5FF2150", VA = "0x185FF2D50")]
		public MutableOverridableObscuredInt(bool GNBAFAOHAEE, ObscuredInt PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2C80", Offset = "0x5FF2080", VA = "0x185FF2C80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2B80", Offset = "0x5FF1F80", VA = "0x185FF2B80", Slot = "20")]
		public override void MDOAMNMJALM(byte[] KLHEEAOCGIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5FF29E0", Offset = "0x5FF1DE0", VA = "0x185FF29E0", Slot = "19")]
		public override void LGIIKINAFJF(DOKLNDCHENH FOLBNLFCLOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2AA0", Offset = "0x5FF1EA0", VA = "0x185FF2AA0", Slot = "18")]
		public override DOKLNDCHENH MBMFDGMCFKN()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, JBGAOPDHKMP>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2910", Offset = "0x5FF1D10", VA = "0x185FF2910")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2970", Offset = "0x5FF1D70", VA = "0x185FF2970")]
		public MutableOverridableObscuredFloat(bool GNBAFAOHAEE, ObscuredFloat PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2840", Offset = "0x5FF1C40", VA = "0x185FF2840", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2740", Offset = "0x5FF1B40", VA = "0x185FF2740", Slot = "20")]
		public override void MDOAMNMJALM(byte[] KLHEEAOCGIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2580", Offset = "0x5FF1980", VA = "0x185FF2580", Slot = "19")]
		public override void LGIIKINAFJF(JBGAOPDHKMP FOLBNLFCLOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2650", Offset = "0x5FF1A50", VA = "0x185FF2650", Slot = "18")]
		public override JBGAOPDHKMP MBMFDGMCFKN()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, BBMMJBJIALE>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5FF1880", Offset = "0x5FF0C80", VA = "0x185FF1880")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2510", Offset = "0x5FF1910", VA = "0x185FF2510")]
		public MutableOverridableObscuredBool(bool GNBAFAOHAEE, ObscuredBool PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2440", Offset = "0x5FF1840", VA = "0x185FF2440", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2340", Offset = "0x5FF1740", VA = "0x185FF2340", Slot = "20")]
		public override void MDOAMNMJALM(byte[] KLHEEAOCGIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5FF21A0", Offset = "0x5FF15A0", VA = "0x185FF21A0", Slot = "19")]
		public override void LGIIKINAFJF(BBMMJBJIALE FOLBNLFCLOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2260", Offset = "0x5FF1660", VA = "0x185FF2260", Slot = "18")]
		public override BBMMJBJIALE MBMFDGMCFKN()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, global::OLCMOHGHOMD<ObscuredBool>, global::IBOMCFBLIHM<ObscuredBool>, global::IIPHBKJKPKI<ObscuredBool>, KPMPHCAIFHG
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6883D0", Offset = "0x6877D0", VA = "0x1806883D0", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x779640", Offset = "0x778A40", VA = "0x180779640", Slot = "22")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5FF1880", Offset = "0x5FF0C80", VA = "0x185FF1880")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5FF1800", Offset = "0x5FF0C00", VA = "0x185FF1800")]
		public void IDBECLNIPFO(MutableOverridableDefaultableObscuredBool BKBGGIICJOJ)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, DOKLNDCHENH> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x3457320", Offset = "0x3456720", VA = "0x183457320", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x3457400", Offset = "0x3456800", VA = "0x183457400", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x23EB2A0", Offset = "0x23EA6A0", VA = "0x1823EB2A0")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x34572F0", Offset = "0x34566F0", VA = "0x1834572F0")]
		public SerializedMutableOverridableObscuredEnum(TObsEnum PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x33028E0", Offset = "0x3301CE0", VA = "0x1833028E0")]
		public SerializedMutableOverridableObscuredEnum(bool GNBAFAOHAEE, TObsEnum PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3457140", Offset = "0x3456540", VA = "0x183457140", Slot = "18")]
		public sealed override DOKLNDCHENH MBMFDGMCFKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3457030", Offset = "0x3456430", VA = "0x183457030", Slot = "19")]
		public sealed override void LGIIKINAFJF(DOKLNDCHENH FOLBNLFCLOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x34571F0", Offset = "0x34565F0", VA = "0x1834571F0", Slot = "20")]
		public sealed override void MDOAMNMJALM(byte[] KLHEEAOCGIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3456FD0", Offset = "0x34563D0", VA = "0x183456FD0", Slot = "17")]
		public sealed override void ACEKBINJHGC()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, CFAKOOCEDME>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5FF20D0", Offset = "0x5FF14D0", VA = "0x185FF20D0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x5FF2110", Offset = "0x5FF1510", VA = "0x185FF2110", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5FF1FE0", Offset = "0x5FF13E0", VA = "0x185FF1FE0")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2070", Offset = "0x5FF1470", VA = "0x185FF2070")]
		public MutableOverridableListObscuredString(bool GNBAFAOHAEE, List<ObscuredString> PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5FF1F40", Offset = "0x5FF1340", VA = "0x185FF1F40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5FF18F0", Offset = "0x5FF0CF0", VA = "0x185FF18F0", Slot = "17")]
		public override void ACEKBINJHGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5FF1E40", Offset = "0x5FF1240", VA = "0x185FF1E40", Slot = "20")]
		public override void MDOAMNMJALM(byte[] KLHEEAOCGIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5FF1960", Offset = "0x5FF0D60", VA = "0x185FF1960", Slot = "19")]
		public override void LGIIKINAFJF(CFAKOOCEDME FOLBNLFCLOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5FF1C80", Offset = "0x5FF1080", VA = "0x185FF1C80", Slot = "18")]
		public override CFAKOOCEDME MBMFDGMCFKN()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : global::IIPHBKJKPKI<Vector3>, KPMPHCAIFHG
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
			[Cpp2IlInjected.Address(RVA = "0x8D3330", Offset = "0x8D2730", VA = "0x1808D3330", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5FF3060", Offset = "0x5FF2460", VA = "0x185FF3060", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x1EC5C10", Offset = "0x1EC5010", VA = "0x181EC5C10", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5FF3040", Offset = "0x5FF2440", VA = "0x185FF3040")]
		public OverridableVector3(Vector3 PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2FA0", Offset = "0x5FF23A0", VA = "0x185FF2FA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2F80", Offset = "0x5FF2380", VA = "0x185FF2F80")]
		public static OverridableVector3 IGKGMCHPHKB(Vector3 IACKENKPPHN)
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
