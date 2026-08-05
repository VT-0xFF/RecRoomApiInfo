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
public interface KEGDJHIIIKM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool CLBNGLGDJIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object AFCGGJCNNBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PCECKHDIOPN<T> : KEGDJHIIIKM
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T MHFLHGKPHDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FNBDNHMDHGK<T> : PCECKHDIOPN<T>, KEGDJHIIIKM
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool CLBNGLGDJIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T MHFLHGKPHDB
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
public interface IPJOEIHKFJO<T> : FNBDNHMDHGK<T>, PCECKHDIOPN<T>, KEGDJHIIIKM
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool NPIBGIIMJAD
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
	public struct OverridableInt : PCECKHDIOPN<int>, KEGDJHIIIKM
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
			[Cpp2IlInjected.Address(RVA = "0xAFF9B0", Offset = "0xAFE1B0", VA = "0x180AFF9B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6F14A10", Offset = "0x6F13210", VA = "0x186F14A10", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x293C5C0", Offset = "0x293ADC0", VA = "0x18293C5C0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F14970", Offset = "0x6F13170", VA = "0x186F14970", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : PCECKHDIOPN<string>, KEGDJHIIIKM
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
			[Cpp2IlInjected.Address(RVA = "0xAFF9B0", Offset = "0xAFE1B0", VA = "0x180AFF9B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9BC8B0", Offset = "0x9BB0B0", VA = "0x1809BC8B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9BC8B0", Offset = "0x9BB0B0", VA = "0x1809BC8B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6F14A60", Offset = "0x6F13260", VA = "0x186F14A60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : FNBDNHMDHGK<InnerType>, PCECKHDIOPN<InnerType>, KEGDJHIIIKM where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool CLBNGLGDJIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType MHFLHGKPHDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object AFCGGJCNNBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x24CB2F0", Offset = "0x24C9AF0", VA = "0x1824CB2F0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4A356C0", Offset = "0x4A33EC0", VA = "0x184A356C0")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4A356F0", Offset = "0x4A33EF0", VA = "0x184A356F0")]
		public MutableOverridableBase(bool PNBHNPEAJLA, [NotNull] InnerType INDENPJBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4A35270", Offset = "0x4A33A70", VA = "0x184A35270", Slot = "15")]
		public void JKHOHOPGAOO(PCECKHDIOPN<InnerType> PPBHJEMIBIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4A34DF0", Offset = "0x4A335F0", VA = "0x184A34DF0", Slot = "16")]
		public void GPGJNKBEMKC(PCECKHDIOPN<InnerType> LIHCAHPMPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4A34D50", Offset = "0x4A33550", VA = "0x184A34D50", Slot = "17")]
		public virtual void FGGFCKBCIEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType EHJDAECGPMM();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void CGFCGPBDHML(ProtobufType ANPGJIABHOP);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void ENNBFMFHFJL(byte[] AOCJAOMNBKE);
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
			[Cpp2IlInjected.Address(RVA = "0x95C5D0", Offset = "0x95ADD0", VA = "0x18095C5D0", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x95C5F0", Offset = "0x95ADF0", VA = "0x18095C5F0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA028A0", Offset = "0xA010A0", VA = "0x180A028A0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3CC6850", Offset = "0x3CC5050", VA = "0x183CC6850")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4649A80", Offset = "0x4648280", VA = "0x184649A80")]
		public SerializedMutableOverridableBase(bool PNBHNPEAJLA, InnerType INDENPJBLHO)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, CAPGOJOPOBA>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6F148A0", Offset = "0x6F130A0", VA = "0x186F148A0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6F14900", Offset = "0x6F13100", VA = "0x186F14900")]
		public MutableOverridableObscuredInt(bool PNBHNPEAJLA, ObscuredInt INDENPJBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6F147D0", Offset = "0x6F12FD0", VA = "0x186F147D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6F146F0", Offset = "0x6F12EF0", VA = "0x186F146F0", Slot = "20")]
		public override void ENNBFMFHFJL(byte[] AOCJAOMNBKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6F14560", Offset = "0x6F12D60", VA = "0x186F14560", Slot = "19")]
		public override void CGFCGPBDHML(CAPGOJOPOBA ANPGJIABHOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6F14610", Offset = "0x6F12E10", VA = "0x186F14610", Slot = "18")]
		public override CAPGOJOPOBA EHJDAECGPMM()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, MOKANFINBAF>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6F14490", Offset = "0x6F12C90", VA = "0x186F14490")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6F144F0", Offset = "0x6F12CF0", VA = "0x186F144F0")]
		public MutableOverridableObscuredFloat(bool PNBHNPEAJLA, ObscuredFloat INDENPJBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6F143C0", Offset = "0x6F12BC0", VA = "0x186F143C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6F142E0", Offset = "0x6F12AE0", VA = "0x186F142E0", Slot = "20")]
		public override void ENNBFMFHFJL(byte[] AOCJAOMNBKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6F14130", Offset = "0x6F12930", VA = "0x186F14130", Slot = "19")]
		public override void CGFCGPBDHML(MOKANFINBAF ANPGJIABHOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6F141F0", Offset = "0x6F129F0", VA = "0x186F141F0", Slot = "18")]
		public override MOKANFINBAF EHJDAECGPMM()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, GODPHAEIJLL>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6F13340", Offset = "0x6F11B40", VA = "0x186F13340")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6F140C0", Offset = "0x6F128C0", VA = "0x186F140C0")]
		public MutableOverridableObscuredBool(bool PNBHNPEAJLA, ObscuredBool INDENPJBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6F13FF0", Offset = "0x6F127F0", VA = "0x186F13FF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6F13E80", Offset = "0x6F12680", VA = "0x186F13E80", Slot = "20")]
		public override void ENNBFMFHFJL(byte[] AOCJAOMNBKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6F13CD0", Offset = "0x6F124D0", VA = "0x186F13CD0", Slot = "19")]
		public override void CGFCGPBDHML(GODPHAEIJLL ANPGJIABHOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6F13D90", Offset = "0x6F12590", VA = "0x186F13D90", Slot = "18")]
		public override GODPHAEIJLL EHJDAECGPMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6F13F60", Offset = "0x6F12760", VA = "0x186F13F60", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, IPJOEIHKFJO<ObscuredBool>, FNBDNHMDHGK<ObscuredBool>, PCECKHDIOPN<ObscuredBool>, KEGDJHIIIKM
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8BB030", Offset = "0x8B9830", VA = "0x1808BB030", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8BB010", Offset = "0x8B9810", VA = "0x1808BB010", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6F13340", Offset = "0x6F11B40", VA = "0x186F13340")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6F132C0", Offset = "0x6F11AC0", VA = "0x186F132C0")]
		public void JKHOHOPGAOO(MutableOverridableDefaultableObscuredBool LIHCAHPMPHD)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, CAPGOJOPOBA> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x4E6DA90", Offset = "0x4E6C290", VA = "0x184E6DA90", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x4E6DC10", Offset = "0x4E6C410", VA = "0x184E6DC10", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3CE7EA0", Offset = "0x3CE66A0", VA = "0x183CE7EA0")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4E6DA50", Offset = "0x4E6C250", VA = "0x184E6DA50")]
		public SerializedMutableOverridableObscuredEnum(bool PNBHNPEAJLA, TObsEnum INDENPJBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4E6D800", Offset = "0x4E6C000", VA = "0x184E6D800", Slot = "18")]
		public sealed override CAPGOJOPOBA EHJDAECGPMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4E6D700", Offset = "0x4E6BF00", VA = "0x184E6D700", Slot = "19")]
		public sealed override void CGFCGPBDHML(CAPGOJOPOBA ANPGJIABHOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4E6D8F0", Offset = "0x4E6C0F0", VA = "0x184E6D8F0", Slot = "20")]
		public sealed override void ENNBFMFHFJL(byte[] AOCJAOMNBKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4E6D9D0", Offset = "0x4E6C1D0", VA = "0x184E6D9D0", Slot = "17")]
		public sealed override void FGGFCKBCIEA()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, PPBBILHMGEI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6F13C00", Offset = "0x6F12400", VA = "0x186F13C00", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6F13C40", Offset = "0x6F12440", VA = "0x186F13C40", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6F13B60", Offset = "0x6F12360", VA = "0x186F13B60")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6F13B00", Offset = "0x6F12300", VA = "0x186F13B00")]
		public MutableOverridableListObscuredString(bool PNBHNPEAJLA, List<ObscuredString> INDENPJBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6F13A60", Offset = "0x6F12260", VA = "0x186F13A60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6F139D0", Offset = "0x6F121D0", VA = "0x186F139D0", Slot = "17")]
		public override void FGGFCKBCIEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6F138F0", Offset = "0x6F120F0", VA = "0x186F138F0", Slot = "20")]
		public override void ENNBFMFHFJL(byte[] AOCJAOMNBKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6F133B0", Offset = "0x6F11BB0", VA = "0x186F133B0", Slot = "19")]
		public override void CGFCGPBDHML(PPBBILHMGEI ANPGJIABHOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6F13710", Offset = "0x6F11F10", VA = "0x186F13710", Slot = "18")]
		public override PPBBILHMGEI EHJDAECGPMM()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : PCECKHDIOPN<Vector3>, KEGDJHIIIKM
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
			[Cpp2IlInjected.Address(RVA = "0xAFF9B0", Offset = "0xAFE1B0", VA = "0x180AFF9B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6F14B90", Offset = "0x6F13390", VA = "0x186F14B90", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x46D1EC0", Offset = "0x46D06C0", VA = "0x1846D1EC0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4B1B690", Offset = "0x4B19E90", VA = "0x184B1B690")]
		public OverridableVector3(Vector3 INDENPJBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x51136D0", Offset = "0x5111ED0", VA = "0x1851136D0")]
		public OverridableVector3(bool PNBHNPEAJLA, Vector3 INDENPJBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6F14AF0", Offset = "0x6F132F0", VA = "0x186F14AF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6F14AD0", Offset = "0x6F132D0", VA = "0x186F14AD0")]
		public static OverridableVector3 FMEIMHFCNHG(Vector3 DBIIPNGMHFP)
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
