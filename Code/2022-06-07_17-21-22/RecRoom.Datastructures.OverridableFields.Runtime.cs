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
			[Cpp2IlInjected.Address(RVA = "0xAF8850", Offset = "0xAF7050", VA = "0x180AF8850", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x4EE8150", Offset = "0x4EE6950", VA = "0x184EE8150", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7961D0", Offset = "0x7949D0", VA = "0x1807961D0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4EE80D0", Offset = "0x4EE68D0", VA = "0x184EE80D0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0xAF8850", Offset = "0xAF7050", VA = "0x180AF8850", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x826EC0", Offset = "0x8256C0", VA = "0x180826EC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x826EC0", Offset = "0x8256C0", VA = "0x180826EC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4EE81A0", Offset = "0x4EE69A0", VA = "0x184EE81A0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x28246E0", Offset = "0x2822EE0", VA = "0x1828246E0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x28244C0", Offset = "0x2822CC0", VA = "0x1828244C0")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2824570", Offset = "0x2822D70", VA = "0x182824570")]
		public MutableOverridableBase(bool OLHGNPEELKD, [NotNull] InnerType MFBIHMKFNKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2823D50", Offset = "0x2822550", VA = "0x182823D50", Slot = "15")]
		public void COBACNEABLE(global::IIAJIOIKDIC<InnerType> KOFNOBPNFGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2824370", Offset = "0x2822B70", VA = "0x182824370", Slot = "16")]
		public void OCJFMPFJFPL(global::IIAJIOIKDIC<InnerType> GKBKHIIEFAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2823F50", Offset = "0x2822750", VA = "0x182823F50", Slot = "17")]
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
			[Cpp2IlInjected.Address(RVA = "0x58C7B0", Offset = "0x58AFB0", VA = "0x18058C7B0", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5E38C0", Offset = "0x5E20C0", VA = "0x1805E38C0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x1059670", Offset = "0x1057E70", VA = "0x181059670", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1B9E800", Offset = "0x1B9D000", VA = "0x181B9E800")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x282DA50", Offset = "0x282C250", VA = "0x18282DA50")]
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
			[Cpp2IlInjected.Address(RVA = "0x282DEC0", Offset = "0x282C6C0", VA = "0x18282DEC0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x282DFA0", Offset = "0x282C7A0", VA = "0x18282DFA0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1DD9F60", Offset = "0x1DD8760", VA = "0x181DD9F60")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x282DE90", Offset = "0x282C690", VA = "0x18282DE90")]
		public SerializedMutableOverridableObscuredEnum(TObsEnum MFBIHMKFNKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x282DE60", Offset = "0x282C660", VA = "0x18282DE60")]
		public SerializedMutableOverridableObscuredEnum(bool OLHGNPEELKD, TObsEnum MFBIHMKFNKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x282DC50", Offset = "0x282C450", VA = "0x18282DC50", Slot = "18")]
		public sealed override OHONOMGCAHC CDLNFCNCLMA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x282DB40", Offset = "0x282C340", VA = "0x18282DB40", Slot = "19")]
		public sealed override void ALBCBJCNGHB(OHONOMGCAHC NALDNLPLLGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x282DD70", Offset = "0x282C570", VA = "0x18282DD70", Slot = "20")]
		public sealed override void JCLHKDDOEEE(byte[] KBDJBAOPHLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x282DD10", Offset = "0x282C510", VA = "0x18282DD10", Slot = "17")]
		public sealed override void IDHIAHKAEGM()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, OHONOMGCAHC>
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4EE8060", Offset = "0x4EE6860", VA = "0x184EE8060")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4EE7FF0", Offset = "0x4EE67F0", VA = "0x184EE7FF0")]
		public MutableOverridableObscuredInt(bool OLHGNPEELKD, ObscuredInt MFBIHMKFNKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4EE7F40", Offset = "0x4EE6740", VA = "0x184EE7F40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4EE7E50", Offset = "0x4EE6650", VA = "0x184EE7E50", Slot = "20")]
		public override void JCLHKDDOEEE(byte[] KBDJBAOPHLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4EE7CC0", Offset = "0x4EE64C0", VA = "0x184EE7CC0", Slot = "19")]
		public override void ALBCBJCNGHB(OHONOMGCAHC NALDNLPLLGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4EE7D80", Offset = "0x4EE6580", VA = "0x184EE7D80", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x4EE7BE0", Offset = "0x4EE63E0", VA = "0x184EE7BE0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4EE7C50", Offset = "0x4EE6450", VA = "0x184EE7C50")]
		public MutableOverridableObscuredFloat(bool OLHGNPEELKD, ObscuredFloat MFBIHMKFNKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4EE7B30", Offset = "0x4EE6330", VA = "0x184EE7B30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4EE7A40", Offset = "0x4EE6240", VA = "0x184EE7A40", Slot = "20")]
		public override void JCLHKDDOEEE(byte[] KBDJBAOPHLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4EE7890", Offset = "0x4EE6090", VA = "0x184EE7890", Slot = "19")]
		public override void ALBCBJCNGHB(FNHOOPKPDAE NALDNLPLLGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4EE7960", Offset = "0x4EE6160", VA = "0x184EE7960", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x4EE77C0", Offset = "0x4EE5FC0", VA = "0x184EE77C0")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4EE7820", Offset = "0x4EE6020", VA = "0x184EE7820")]
		public MutableOverridableObscuredBool(bool OLHGNPEELKD, ObscuredBool MFBIHMKFNKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4EE7710", Offset = "0x4EE5F10", VA = "0x184EE7710", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4EE7620", Offset = "0x4EE5E20", VA = "0x184EE7620", Slot = "20")]
		public override void JCLHKDDOEEE(byte[] KBDJBAOPHLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4EE7480", Offset = "0x4EE5C80", VA = "0x184EE7480", Slot = "19")]
		public override void ALBCBJCNGHB(EIHOGHEGECC NALDNLPLLGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4EE7540", Offset = "0x4EE5D40", VA = "0x184EE7540", Slot = "18")]
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
			[Cpp2IlInjected.Address(RVA = "0x4EE73D0", Offset = "0x4EE5BD0", VA = "0x184EE73D0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x4EE7410", Offset = "0x4EE5C10", VA = "0x184EE7410", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4EE7350", Offset = "0x4EE5B50", VA = "0x184EE7350")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4EE72F0", Offset = "0x4EE5AF0", VA = "0x184EE72F0")]
		public MutableOverridableListObscuredString(bool OLHGNPEELKD, List<ObscuredString> MFBIHMKFNKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4EE7260", Offset = "0x4EE5A60", VA = "0x184EE7260", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4EE7100", Offset = "0x4EE5900", VA = "0x184EE7100", Slot = "17")]
		public override void IDHIAHKAEGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4EE7170", Offset = "0x4EE5970", VA = "0x184EE7170", Slot = "20")]
		public override void JCLHKDDOEEE(byte[] KBDJBAOPHLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4EE6C50", Offset = "0x4EE5450", VA = "0x184EE6C50", Slot = "19")]
		public override void ALBCBJCNGHB(BDAICLICIBN NALDNLPLLGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4EE6F50", Offset = "0x4EE5750", VA = "0x184EE6F50", Slot = "18")]
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
			[Cpp2IlInjected.Address(RVA = "0xAF8850", Offset = "0xAF7050", VA = "0x180AF8850", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x4EE82D0", Offset = "0x4EE6AD0", VA = "0x184EE82D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x23C9E10", Offset = "0x23C8610", VA = "0x1823C9E10", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4EE82B0", Offset = "0x4EE6AB0", VA = "0x184EE82B0")]
		public OverridableVector3(Vector3 MFBIHMKFNKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4EE8220", Offset = "0x4EE6A20", VA = "0x184EE8220", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x4EE8200", Offset = "0x4EE6A00", VA = "0x184EE8200")]
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
