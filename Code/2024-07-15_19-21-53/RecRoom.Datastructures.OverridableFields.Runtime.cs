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
			[Cpp2IlInjected.Address(RVA = "0x1D74020", Offset = "0x1D72820", VA = "0x181D74020", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x68A7720", Offset = "0x68A5F20", VA = "0x1868A7720", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x255BA90", Offset = "0x255A290", VA = "0x18255BA90", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x68A7680", Offset = "0x68A5E80", VA = "0x1868A7680", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D74020", Offset = "0x1D72820", VA = "0x181D74020", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8C4100", Offset = "0x8C2900", VA = "0x1808C4100", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8C4100", Offset = "0x8C2900", VA = "0x1808C4100", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x68A7770", Offset = "0x68A5F70", VA = "0x1868A7770", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x215DC70", Offset = "0x215C470", VA = "0x18215DC70", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x44EFAD0", Offset = "0x44EE2D0", VA = "0x1844EFAD0")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x44EFB00", Offset = "0x44EE300", VA = "0x1844EFB00")]
		public MutableOverridableBase(bool GPAACDKKHMD, [NotNull] InnerType JMDCGOKJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x44EF7E0", Offset = "0x44EDFE0", VA = "0x1844EF7E0", Slot = "15")]
		public void MINGFKCBMBL(PPOHJLFCABI<InnerType> DPHPOBDCMJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x44EF2E0", Offset = "0x44EDAE0", VA = "0x1844EF2E0", Slot = "16")]
		public void JGFBHDIGANM(PPOHJLFCABI<InnerType> OKGBBGMIACH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x44EF980", Offset = "0x44EE180", VA = "0x1844EF980", Slot = "17")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A6510", Offset = "0x8A4D10", VA = "0x1808A6510", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x9AD960", Offset = "0x9AC160", VA = "0x1809AD960", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1C5AF10", Offset = "0x1C59710", VA = "0x181C5AF10", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3D059F0", Offset = "0x3D041F0", VA = "0x183D059F0")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x40A99E0", Offset = "0x40A81E0", VA = "0x1840A99E0")]
		public SerializedMutableOverridableBase(bool GPAACDKKHMD, InnerType JMDCGOKJIDA)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, OKIGEJEINKH>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x68A75B0", Offset = "0x68A5DB0", VA = "0x1868A75B0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x68A7610", Offset = "0x68A5E10", VA = "0x1868A7610")]
		public MutableOverridableObscuredInt(bool GPAACDKKHMD, ObscuredInt JMDCGOKJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x68A74E0", Offset = "0x68A5CE0", VA = "0x1868A74E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x68A7350", Offset = "0x68A5B50", VA = "0x1868A7350", Slot = "20")]
		public override void DBCBNODOKIN(byte[] EALHOFMJIMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x68A7430", Offset = "0x68A5C30", VA = "0x1868A7430", Slot = "19")]
		public override void DMGFCBFCANJ(OKIGEJEINKH KIKMALBGNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x68A7270", Offset = "0x68A5A70", VA = "0x1868A7270", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x68A71A0", Offset = "0x68A59A0", VA = "0x1868A71A0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x68A7200", Offset = "0x68A5A00", VA = "0x1868A7200")]
		public MutableOverridableObscuredFloat(bool GPAACDKKHMD, ObscuredFloat JMDCGOKJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x68A70D0", Offset = "0x68A58D0", VA = "0x1868A70D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x68A6F30", Offset = "0x68A5730", VA = "0x1868A6F30", Slot = "20")]
		public override void DBCBNODOKIN(byte[] EALHOFMJIMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x68A7010", Offset = "0x68A5810", VA = "0x1868A7010", Slot = "19")]
		public override void DMGFCBFCANJ(MBHMJMFJADC KIKMALBGNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x68A6E40", Offset = "0x68A5640", VA = "0x1868A6E40", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x68A6050", Offset = "0x68A4850", VA = "0x1868A6050")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x68A6DD0", Offset = "0x68A55D0", VA = "0x1868A6DD0")]
		public MutableOverridableObscuredBool(bool GPAACDKKHMD, ObscuredBool JMDCGOKJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x68A6D00", Offset = "0x68A5500", VA = "0x1868A6D00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x68A6AD0", Offset = "0x68A52D0", VA = "0x1868A6AD0", Slot = "20")]
		public override void DBCBNODOKIN(byte[] EALHOFMJIMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x68A6BB0", Offset = "0x68A53B0", VA = "0x1868A6BB0", Slot = "19")]
		public override void DMGFCBFCANJ(PKKEFCMBKBD KIKMALBGNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x68A69E0", Offset = "0x68A51E0", VA = "0x1868A69E0", Slot = "18")]
		public override PKKEFCMBKBD BNBHIEMPECA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x68A6C70", Offset = "0x68A5470", VA = "0x1868A6C70", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "21")]
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
			[Cpp2IlInjected.Address(RVA = "0x8569B0", Offset = "0x8551B0", VA = "0x1808569B0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8569C0", Offset = "0x8551C0", VA = "0x1808569C0", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x68A6050", Offset = "0x68A4850", VA = "0x1868A6050")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x68A5FD0", Offset = "0x68A47D0", VA = "0x1868A5FD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4956190", Offset = "0x4954990", VA = "0x184956190", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x4956300", Offset = "0x4954B00", VA = "0x184956300", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3CC0640", Offset = "0x3CBEE40", VA = "0x183CC0640")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4956150", Offset = "0x4954950", VA = "0x184956150")]
		public SerializedMutableOverridableObscuredEnum(bool GPAACDKKHMD, TObsEnum JMDCGOKJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4955E00", Offset = "0x4954600", VA = "0x184955E00", Slot = "18")]
		public sealed override OKIGEJEINKH BNBHIEMPECA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4955FD0", Offset = "0x49547D0", VA = "0x184955FD0", Slot = "19")]
		public sealed override void DMGFCBFCANJ(OKIGEJEINKH KIKMALBGNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4955EF0", Offset = "0x49546F0", VA = "0x184955EF0", Slot = "20")]
		public sealed override void DBCBNODOKIN(byte[] EALHOFMJIMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x49560D0", Offset = "0x49548D0", VA = "0x1849560D0", Slot = "17")]
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
			[Cpp2IlInjected.Address(RVA = "0x68A6910", Offset = "0x68A5110", VA = "0x1868A6910", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x68A6950", Offset = "0x68A5150", VA = "0x1868A6950", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x68A6870", Offset = "0x68A5070", VA = "0x1868A6870")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x68A6810", Offset = "0x68A5010", VA = "0x1868A6810")]
		public MutableOverridableListObscuredString(bool GPAACDKKHMD, List<ObscuredString> JMDCGOKJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x68A6770", Offset = "0x68A4F70", VA = "0x1868A6770", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x68A66E0", Offset = "0x68A4EE0", VA = "0x1868A66E0", Slot = "17")]
		public override void MJPMKPPBJPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x68A62A0", Offset = "0x68A4AA0", VA = "0x1868A62A0", Slot = "20")]
		public override void DBCBNODOKIN(byte[] EALHOFMJIMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x68A6380", Offset = "0x68A4B80", VA = "0x1868A6380", Slot = "19")]
		public override void DMGFCBFCANJ(GDJCMJFIJHO KIKMALBGNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x68A60C0", Offset = "0x68A48C0", VA = "0x1868A60C0", Slot = "18")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D74020", Offset = "0x1D72820", VA = "0x181D74020", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x68A78A0", Offset = "0x68A60A0", VA = "0x1868A78A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x4222590", Offset = "0x4220D90", VA = "0x184222590", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x45F15E0", Offset = "0x45EFDE0", VA = "0x1845F15E0")]
		public OverridableVector3(Vector3 JMDCGOKJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4BE7A10", Offset = "0x4BE6210", VA = "0x184BE7A10")]
		public OverridableVector3(bool GPAACDKKHMD, Vector3 JMDCGOKJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x68A7800", Offset = "0x68A6000", VA = "0x1868A7800", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x68A77E0", Offset = "0x68A5FE0", VA = "0x1868A77E0")]
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
