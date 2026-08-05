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
public interface DKNMAMHCJFM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KNBJLEGNEGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object OJMAAJGMOKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IIAJIOIKDIC<T> : DKNMAMHCJFM
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T CIFMBHMEFPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface ODECMPBHIGE<T> : global::IIAJIOIKDIC<T>, DKNMAMHCJFM
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool KNBJLEGNEGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T CIFMBHMEFPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
namespace RecRoom.Utils.OverridableFields
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct OverridableInt : global::IIAJIOIKDIC<int>, DKNMAMHCJFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private int value;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAC0900", Offset = "0xABF900", VA = "0x180AC0900", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x4D7FED0", Offset = "0x4D7EED0", VA = "0x184D7FED0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6BDD40", Offset = "0x6BCD40", VA = "0x1806BDD40", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4D7FE50", Offset = "0x4D7EE50", VA = "0x184D7FE50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct OverridableString : global::IIAJIOIKDIC<string>, DKNMAMHCJFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private string value;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xAC0900", Offset = "0xABF900", VA = "0x180AC0900", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x595040", Offset = "0x594040", VA = "0x180595040", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x595040", Offset = "0x594040", VA = "0x180595040", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4D7FF20", Offset = "0x4D7EF20", VA = "0x184D7FF20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : global::ODECMPBHIGE<InnerType>, global::IIAJIOIKDIC<InnerType>, DKNMAMHCJFM where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public abstract bool KNBJLEGNEGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract InnerType CIFMBHMEFPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public object OJMAAJGMOKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x23DF220", Offset = "0x23DE220", VA = "0x1823DF220", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x23DF000", Offset = "0x23DE000", VA = "0x1823DF000")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x23DF0B0", Offset = "0x23DE0B0", VA = "0x1823DF0B0")]
		public MutableOverridableBase(bool OLHGNPEELKD, [NotNull] InnerType MFBIHMKFNKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x23DE890", Offset = "0x23DD890", VA = "0x1823DE890", Slot = "15")]
		public void COBACNEABLE(global::IIAJIOIKDIC<InnerType> KOFNOBPNFGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x23DEEB0", Offset = "0x23DDEB0", VA = "0x1823DEEB0", Slot = "16")]
		public void OCJFMPFJFPL(global::IIAJIOIKDIC<InnerType> GKBKHIIEFAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x23DEA90", Offset = "0x23DDA90", VA = "0x1823DEA90", Slot = "17")]
		public virtual void IDHIAHKAEGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType CDLNFCNCLMA();

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void ALBCBJCNGHB(ProtobufType NALDNLPLLGP);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void JCLHKDDOEEE(byte[] KBDJBAOPHLB);
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
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

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x5550C0", Offset = "0x5540C0", VA = "0x1805550C0", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5550B0", Offset = "0x5540B0", VA = "0x1805550B0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x89AB70", Offset = "0x899B70", VA = "0x18089AB70", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x14076E0", Offset = "0x14066E0", VA = "0x1814076E0")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x23E2AB0", Offset = "0x23E1AB0", VA = "0x1823E2AB0")]
		public SerializedMutableOverridableBase(bool OLHGNPEELKD, InnerType MFBIHMKFNKA)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, OHONOMGCAHC> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x23E2F20", Offset = "0x23E1F20", VA = "0x1823E2F20", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x23E3000", Offset = "0x23E2000", VA = "0x1823E3000", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1412070", Offset = "0x1411070", VA = "0x181412070")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x23E2EF0", Offset = "0x23E1EF0", VA = "0x1823E2EF0")]
		public SerializedMutableOverridableObscuredEnum(TObsEnum MFBIHMKFNKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x23E2EC0", Offset = "0x23E1EC0", VA = "0x1823E2EC0")]
		public SerializedMutableOverridableObscuredEnum(bool OLHGNPEELKD, TObsEnum MFBIHMKFNKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x23E2CB0", Offset = "0x23E1CB0", VA = "0x1823E2CB0", Slot = "18")]
		public sealed override OHONOMGCAHC CDLNFCNCLMA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x23E2BA0", Offset = "0x23E1BA0", VA = "0x1823E2BA0", Slot = "19")]
		public sealed override void ALBCBJCNGHB(OHONOMGCAHC NALDNLPLLGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x23E2DD0", Offset = "0x23E1DD0", VA = "0x1823E2DD0", Slot = "20")]
		public sealed override void JCLHKDDOEEE(byte[] KBDJBAOPHLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x23E2D70", Offset = "0x23E1D70", VA = "0x1823E2D70", Slot = "17")]
		public sealed override void IDHIAHKAEGM()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, OHONOMGCAHC>
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4D7FDE0", Offset = "0x4D7EDE0", VA = "0x184D7FDE0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4D7FD70", Offset = "0x4D7ED70", VA = "0x184D7FD70")]
		public MutableOverridableObscuredInt(bool OLHGNPEELKD, ObscuredInt MFBIHMKFNKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4D7FCC0", Offset = "0x4D7ECC0", VA = "0x184D7FCC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4D7FBD0", Offset = "0x4D7EBD0", VA = "0x184D7FBD0", Slot = "20")]
		public override void JCLHKDDOEEE(byte[] KBDJBAOPHLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4D7FA40", Offset = "0x4D7EA40", VA = "0x184D7FA40", Slot = "19")]
		public override void ALBCBJCNGHB(OHONOMGCAHC NALDNLPLLGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4D7FB00", Offset = "0x4D7EB00", VA = "0x184D7FB00", Slot = "18")]
		public override OHONOMGCAHC CDLNFCNCLMA()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, FNHOOPKPDAE>
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4D7F960", Offset = "0x4D7E960", VA = "0x184D7F960")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4D7F9D0", Offset = "0x4D7E9D0", VA = "0x184D7F9D0")]
		public MutableOverridableObscuredFloat(bool OLHGNPEELKD, ObscuredFloat MFBIHMKFNKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4D7F8B0", Offset = "0x4D7E8B0", VA = "0x184D7F8B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4D7F7C0", Offset = "0x4D7E7C0", VA = "0x184D7F7C0", Slot = "20")]
		public override void JCLHKDDOEEE(byte[] KBDJBAOPHLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4D7F610", Offset = "0x4D7E610", VA = "0x184D7F610", Slot = "19")]
		public override void ALBCBJCNGHB(FNHOOPKPDAE NALDNLPLLGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4D7F6E0", Offset = "0x4D7E6E0", VA = "0x184D7F6E0", Slot = "18")]
		public override FNHOOPKPDAE CDLNFCNCLMA()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, EIHOGHEGECC>
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4D7F540", Offset = "0x4D7E540", VA = "0x184D7F540")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4D7F5A0", Offset = "0x4D7E5A0", VA = "0x184D7F5A0")]
		public MutableOverridableObscuredBool(bool OLHGNPEELKD, ObscuredBool MFBIHMKFNKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4D7F490", Offset = "0x4D7E490", VA = "0x184D7F490", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4D7F3A0", Offset = "0x4D7E3A0", VA = "0x184D7F3A0", Slot = "20")]
		public override void JCLHKDDOEEE(byte[] KBDJBAOPHLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4D7F200", Offset = "0x4D7E200", VA = "0x184D7F200", Slot = "19")]
		public override void ALBCBJCNGHB(EIHOGHEGECC NALDNLPLLGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4D7F2C0", Offset = "0x4D7E2C0", VA = "0x184D7F2C0", Slot = "18")]
		public override EIHOGHEGECC CDLNFCNCLMA()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, BDAICLICIBN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x4D7F150", Offset = "0x4D7E150", VA = "0x184D7F150", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x4D7F190", Offset = "0x4D7E190", VA = "0x184D7F190", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4D7F0D0", Offset = "0x4D7E0D0", VA = "0x184D7F0D0")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4D7F070", Offset = "0x4D7E070", VA = "0x184D7F070")]
		public MutableOverridableListObscuredString(bool OLHGNPEELKD, List<ObscuredString> MFBIHMKFNKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4D7EFE0", Offset = "0x4D7DFE0", VA = "0x184D7EFE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4D7EE80", Offset = "0x4D7DE80", VA = "0x184D7EE80", Slot = "17")]
		public override void IDHIAHKAEGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4D7EEF0", Offset = "0x4D7DEF0", VA = "0x184D7EEF0", Slot = "20")]
		public override void JCLHKDDOEEE(byte[] KBDJBAOPHLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4D7E9D0", Offset = "0x4D7D9D0", VA = "0x184D7E9D0", Slot = "19")]
		public override void ALBCBJCNGHB(BDAICLICIBN NALDNLPLLGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4D7ECD0", Offset = "0x4D7DCD0", VA = "0x184D7ECD0", Slot = "18")]
		public override BDAICLICIBN CDLNFCNCLMA()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct OverridableVector3 : global::IIAJIOIKDIC<Vector3>, DKNMAMHCJFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private Vector3 value;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xAC0900", Offset = "0xABF900", VA = "0x180AC0900", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x4D80050", Offset = "0x4D7F050", VA = "0x184D80050", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x1A88FB0", Offset = "0x1A87FB0", VA = "0x181A88FB0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4D80030", Offset = "0x4D7F030", VA = "0x184D80030")]
		public OverridableVector3(Vector3 MFBIHMKFNKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4D7FFA0", Offset = "0x4D7EFA0", VA = "0x184D7FFA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x4D7FF80", Offset = "0x4D7EF80", VA = "0x184D7FF80")]
		public static OverridableVector3 AIKMOHENPEH(Vector3 BPAFLPOFGHP)
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
