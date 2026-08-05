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
public interface CDAILOLFLLE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool OLBGPBEHFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object BLLMBFEAAGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PPOHJLFCABI<T> : CDAILOLFLLE
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T JNHPIMBJPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface MGHDFHIMIJI<T> : PPOHJLFCABI<T>, CDAILOLFLLE
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool OLBGPBEHFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T JNHPIMBJPMJ
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
public interface HDKHEFJLGIO<T> : MGHDFHIMIJI<T>, PPOHJLFCABI<T>, CDAILOLFLLE
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool NMAMNMFNCOI
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
	public struct OverridableInt : PPOHJLFCABI<int>, CDAILOLFLLE
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
			[Cpp2IlInjected.Address(RVA = "0x1D7E510", Offset = "0x1D7D710", VA = "0x181D7E510", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x68C1B10", Offset = "0x68C0D10", VA = "0x1868C1B10", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x256A860", Offset = "0x2569A60", VA = "0x18256A860", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x68C1A70", Offset = "0x68C0C70", VA = "0x1868C1A70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : PPOHJLFCABI<string>, CDAILOLFLLE
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
			[Cpp2IlInjected.Address(RVA = "0x1D7E510", Offset = "0x1D7D710", VA = "0x181D7E510", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8C3F40", Offset = "0x8C3140", VA = "0x1808C3F40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8C3F40", Offset = "0x8C3140", VA = "0x1808C3F40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x68C1B60", Offset = "0x68C0D60", VA = "0x1868C1B60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : MGHDFHIMIJI<InnerType>, PPOHJLFCABI<InnerType>, CDAILOLFLLE where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool OLBGPBEHFHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType JNHPIMBJPMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object BLLMBFEAAGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x216A380", Offset = "0x2169580", VA = "0x18216A380", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4505450", Offset = "0x4504650", VA = "0x184505450")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4505480", Offset = "0x4504680", VA = "0x184505480")]
		public MutableOverridableBase(bool GPAACDKKHMD, [NotNull] InnerType JMDCGOKJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4505160", Offset = "0x4504360", VA = "0x184505160", Slot = "15")]
		public void MINGFKCBMBL(PPOHJLFCABI<InnerType> DPHPOBDCMJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4504C60", Offset = "0x4503E60", VA = "0x184504C60", Slot = "16")]
		public void JGFBHDIGANM(PPOHJLFCABI<InnerType> OKGBBGMIACH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4505300", Offset = "0x4504500", VA = "0x184505300", Slot = "17")]
		public virtual void MJPMKPPBJPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType BNBHIEMPECA();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void DMGFCBFCANJ(ProtobufType KIKMALBGNCI);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void DBCBNODOKIN(byte[] EALHOFMJIMH);
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
			[Cpp2IlInjected.Address(RVA = "0x8A6350", Offset = "0x8A5550", VA = "0x1808A6350", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x9AE710", Offset = "0x9AD910", VA = "0x1809AE710", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1C65020", Offset = "0x1C64220", VA = "0x181C65020", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3D19D30", Offset = "0x3D18F30", VA = "0x183D19D30")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x40BF290", Offset = "0x40BE490", VA = "0x1840BF290")]
		public SerializedMutableOverridableBase(bool GPAACDKKHMD, InnerType JMDCGOKJIDA)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, OKIGEJEINKH>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x68C19A0", Offset = "0x68C0BA0", VA = "0x1868C19A0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x68C1A00", Offset = "0x68C0C00", VA = "0x1868C1A00")]
		public MutableOverridableObscuredInt(bool GPAACDKKHMD, ObscuredInt JMDCGOKJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x68C18D0", Offset = "0x68C0AD0", VA = "0x1868C18D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x68C1740", Offset = "0x68C0940", VA = "0x1868C1740", Slot = "20")]
		public override void DBCBNODOKIN(byte[] EALHOFMJIMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x68C1820", Offset = "0x68C0A20", VA = "0x1868C1820", Slot = "19")]
		public override void DMGFCBFCANJ(OKIGEJEINKH KIKMALBGNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x68C1660", Offset = "0x68C0860", VA = "0x1868C1660", Slot = "18")]
		public override OKIGEJEINKH BNBHIEMPECA()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, MBHMJMFJADC>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x68C1590", Offset = "0x68C0790", VA = "0x1868C1590")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x68C15F0", Offset = "0x68C07F0", VA = "0x1868C15F0")]
		public MutableOverridableObscuredFloat(bool GPAACDKKHMD, ObscuredFloat JMDCGOKJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x68C14C0", Offset = "0x68C06C0", VA = "0x1868C14C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x68C1320", Offset = "0x68C0520", VA = "0x1868C1320", Slot = "20")]
		public override void DBCBNODOKIN(byte[] EALHOFMJIMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x68C1400", Offset = "0x68C0600", VA = "0x1868C1400", Slot = "19")]
		public override void DMGFCBFCANJ(MBHMJMFJADC KIKMALBGNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x68C1230", Offset = "0x68C0430", VA = "0x1868C1230", Slot = "18")]
		public override MBHMJMFJADC BNBHIEMPECA()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, PKKEFCMBKBD>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x68C0440", Offset = "0x68BF640", VA = "0x1868C0440")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x68C11C0", Offset = "0x68C03C0", VA = "0x1868C11C0")]
		public MutableOverridableObscuredBool(bool GPAACDKKHMD, ObscuredBool JMDCGOKJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x68C10F0", Offset = "0x68C02F0", VA = "0x1868C10F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x68C0EC0", Offset = "0x68C00C0", VA = "0x1868C0EC0", Slot = "20")]
		public override void DBCBNODOKIN(byte[] EALHOFMJIMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x68C0FA0", Offset = "0x68C01A0", VA = "0x1868C0FA0", Slot = "19")]
		public override void DMGFCBFCANJ(PKKEFCMBKBD KIKMALBGNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x68C0DD0", Offset = "0x68BFFD0", VA = "0x1868C0DD0", Slot = "18")]
		public override PKKEFCMBKBD BNBHIEMPECA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x68C1060", Offset = "0x68C0260", VA = "0x1868C1060", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, HDKHEFJLGIO<ObscuredBool>, MGHDFHIMIJI<ObscuredBool>, PPOHJLFCABI<ObscuredBool>, CDAILOLFLLE
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8569B0", Offset = "0x855BB0", VA = "0x1808569B0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8569C0", Offset = "0x855BC0", VA = "0x1808569C0", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x68C0440", Offset = "0x68BF640", VA = "0x1868C0440")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x68C03C0", Offset = "0x68BF5C0", VA = "0x1868C03C0")]
		public void MINGFKCBMBL(MutableOverridableDefaultableObscuredBool OKGBBGMIACH)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, OKIGEJEINKH> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x496DDF0", Offset = "0x496CFF0", VA = "0x18496DDF0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x496DF60", Offset = "0x496D160", VA = "0x18496DF60", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3CD4910", Offset = "0x3CD3B10", VA = "0x183CD4910")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x496DDB0", Offset = "0x496CFB0", VA = "0x18496DDB0")]
		public SerializedMutableOverridableObscuredEnum(bool GPAACDKKHMD, TObsEnum JMDCGOKJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x496DA60", Offset = "0x496CC60", VA = "0x18496DA60", Slot = "18")]
		public sealed override OKIGEJEINKH BNBHIEMPECA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x496DC30", Offset = "0x496CE30", VA = "0x18496DC30", Slot = "19")]
		public sealed override void DMGFCBFCANJ(OKIGEJEINKH KIKMALBGNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x496DB50", Offset = "0x496CD50", VA = "0x18496DB50", Slot = "20")]
		public sealed override void DBCBNODOKIN(byte[] EALHOFMJIMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x496DD30", Offset = "0x496CF30", VA = "0x18496DD30", Slot = "17")]
		public sealed override void MJPMKPPBJPO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, GDJCMJFIJHO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x68C0D00", Offset = "0x68BFF00", VA = "0x1868C0D00", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x68C0D40", Offset = "0x68BFF40", VA = "0x1868C0D40", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x68C0C60", Offset = "0x68BFE60", VA = "0x1868C0C60")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x68C0C00", Offset = "0x68BFE00", VA = "0x1868C0C00")]
		public MutableOverridableListObscuredString(bool GPAACDKKHMD, List<ObscuredString> JMDCGOKJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x68C0B60", Offset = "0x68BFD60", VA = "0x1868C0B60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x68C0AD0", Offset = "0x68BFCD0", VA = "0x1868C0AD0", Slot = "17")]
		public override void MJPMKPPBJPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x68C0690", Offset = "0x68BF890", VA = "0x1868C0690", Slot = "20")]
		public override void DBCBNODOKIN(byte[] EALHOFMJIMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x68C0770", Offset = "0x68BF970", VA = "0x1868C0770", Slot = "19")]
		public override void DMGFCBFCANJ(GDJCMJFIJHO KIKMALBGNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x68C04B0", Offset = "0x68BF6B0", VA = "0x1868C04B0", Slot = "18")]
		public override GDJCMJFIJHO BNBHIEMPECA()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : PPOHJLFCABI<Vector3>, CDAILOLFLLE
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
			[Cpp2IlInjected.Address(RVA = "0x1D7E510", Offset = "0x1D7D710", VA = "0x181D7E510", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x68C1C90", Offset = "0x68C0E90", VA = "0x1868C1C90", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x4236480", Offset = "0x4235680", VA = "0x184236480", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x45FC260", Offset = "0x45FB460", VA = "0x1845FC260")]
		public OverridableVector3(Vector3 JMDCGOKJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4C08FA0", Offset = "0x4C081A0", VA = "0x184C08FA0")]
		public OverridableVector3(bool GPAACDKKHMD, Vector3 JMDCGOKJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x68C1BF0", Offset = "0x68C0DF0", VA = "0x1868C1BF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x68C1BD0", Offset = "0x68C0DD0", VA = "0x1868C1BD0")]
		public static OverridableVector3 GCLAHEGAFFN(Vector3 GPBAFILNEOM)
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
