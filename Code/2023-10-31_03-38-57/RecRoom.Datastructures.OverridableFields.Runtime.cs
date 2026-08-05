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
public interface IDEMGGHKMCK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MNADHDFGPDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object ILDFAHDDGMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IHHPEFCHMDK<T> : IDEMGGHKMCK
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T DFNAILAPHHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EBBNFKDLEFD<T> : IHHPEFCHMDK<T>, IDEMGGHKMCK
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool MNADHDFGPDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T DFNAILAPHHN
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
public interface IDDOAFNLIEN<T> : EBBNFKDLEFD<T>, IHHPEFCHMDK<T>, IDEMGGHKMCK
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool HFDEAKLAFPO
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
	public struct OverridableInt : IHHPEFCHMDK<int>, IDEMGGHKMCK
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
			[Cpp2IlInjected.Address(RVA = "0x1926750", Offset = "0x1925B50", VA = "0x181926750", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5C4F970", Offset = "0x5C4ED70", VA = "0x185C4F970", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x200C1F0", Offset = "0x200B5F0", VA = "0x18200C1F0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5C4F8D0", Offset = "0x5C4ECD0", VA = "0x185C4F8D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : IHHPEFCHMDK<string>, IDEMGGHKMCK
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
			[Cpp2IlInjected.Address(RVA = "0x1926750", Offset = "0x1925B50", VA = "0x181926750", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x998C40", Offset = "0x998040", VA = "0x180998C40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x998C40", Offset = "0x998040", VA = "0x180998C40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5C4F9C0", Offset = "0x5C4EDC0", VA = "0x185C4F9C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : EBBNFKDLEFD<InnerType>, IHHPEFCHMDK<InnerType>, IDEMGGHKMCK where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool MNADHDFGPDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType DFNAILAPHHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object ILDFAHDDGMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x3BF3D40", Offset = "0x3BF3140", VA = "0x183BF3D40", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3BF3A00", Offset = "0x3BF2E00", VA = "0x183BF3A00")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3BF3A30", Offset = "0x3BF2E30", VA = "0x183BF3A30")]
		public MutableOverridableBase(bool MPOEHKFOOFJ, [NotNull] InnerType EOHMJBFGDPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3BF37F0", Offset = "0x3BF2BF0", VA = "0x183BF37F0", Slot = "15")]
		public void JILBMBBBJLK(IHHPEFCHMDK<InnerType> BLOPHFGFCPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3BF3130", Offset = "0x3BF2530", VA = "0x183BF3130", Slot = "16")]
		public void GFOOEPCPPKC(IHHPEFCHMDK<InnerType> LJIBJAOOGGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3BF3960", Offset = "0x3BF2D60", VA = "0x183BF3960", Slot = "17")]
		public virtual void OAFECOOGBFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType MNBCFLMIDLJ();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void NMBGAOPKONJ(ProtobufType KEMKENCGIKO);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void DIEMGFGKJCB(byte[] CIHBJOGNBAL);
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
			[Cpp2IlInjected.Address(RVA = "0x7AEE20", Offset = "0x7AE220", VA = "0x1807AEE20", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x89C9F0", Offset = "0x89BDF0", VA = "0x18089C9F0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x182EBC0", Offset = "0x182DFC0", VA = "0x18182EBC0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x33DB470", Offset = "0x33DA870", VA = "0x1833DB470")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3451B30", Offset = "0x3450F30", VA = "0x183451B30")]
		public SerializedMutableOverridableBase(bool MPOEHKFOOFJ, InnerType EOHMJBFGDPD)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, BBAMKHOIJLK>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5C4F800", Offset = "0x5C4EC00", VA = "0x185C4F800")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5C4F860", Offset = "0x5C4EC60", VA = "0x185C4F860")]
		public MutableOverridableObscuredInt(bool MPOEHKFOOFJ, ObscuredInt EOHMJBFGDPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5C4F730", Offset = "0x5C4EB30", VA = "0x185C4F730", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5C4F4C0", Offset = "0x5C4E8C0", VA = "0x185C4F4C0", Slot = "20")]
		public override void DIEMGFGKJCB(byte[] CIHBJOGNBAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5C4F680", Offset = "0x5C4EA80", VA = "0x185C4F680", Slot = "19")]
		public override void NMBGAOPKONJ(BBAMKHOIJLK KEMKENCGIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5C4F5A0", Offset = "0x5C4E9A0", VA = "0x185C4F5A0", Slot = "18")]
		public override BBAMKHOIJLK MNBCFLMIDLJ()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, LHHGJKEEPGO>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5C4F3F0", Offset = "0x5C4E7F0", VA = "0x185C4F3F0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5C4F450", Offset = "0x5C4E850", VA = "0x185C4F450")]
		public MutableOverridableObscuredFloat(bool MPOEHKFOOFJ, ObscuredFloat EOHMJBFGDPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5C4F320", Offset = "0x5C4E720", VA = "0x185C4F320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5C4F090", Offset = "0x5C4E490", VA = "0x185C4F090", Slot = "20")]
		public override void DIEMGFGKJCB(byte[] CIHBJOGNBAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5C4F260", Offset = "0x5C4E660", VA = "0x185C4F260", Slot = "19")]
		public override void NMBGAOPKONJ(LHHGJKEEPGO KEMKENCGIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5C4F170", Offset = "0x5C4E570", VA = "0x185C4F170", Slot = "18")]
		public override LHHGJKEEPGO MNBCFLMIDLJ()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, BCCMACEOLAH>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5C4E2A0", Offset = "0x5C4D6A0", VA = "0x185C4E2A0")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5C4F020", Offset = "0x5C4E420", VA = "0x185C4F020")]
		public MutableOverridableObscuredBool(bool MPOEHKFOOFJ, ObscuredBool EOHMJBFGDPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5C4EF50", Offset = "0x5C4E350", VA = "0x185C4EF50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5C4EC30", Offset = "0x5C4E030", VA = "0x185C4EC30", Slot = "20")]
		public override void DIEMGFGKJCB(byte[] CIHBJOGNBAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5C4EE00", Offset = "0x5C4E200", VA = "0x185C4EE00", Slot = "19")]
		public override void NMBGAOPKONJ(BCCMACEOLAH KEMKENCGIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5C4ED10", Offset = "0x5C4E110", VA = "0x185C4ED10", Slot = "18")]
		public override BCCMACEOLAH MNBCFLMIDLJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5C4EEC0", Offset = "0x5C4E2C0", VA = "0x185C4EEC0", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, IDDOAFNLIEN<ObscuredBool>, EBBNFKDLEFD<ObscuredBool>, IHHPEFCHMDK<ObscuredBool>, IDEMGGHKMCK
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x75C550", Offset = "0x75B950", VA = "0x18075C550", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x75C570", Offset = "0x75B970", VA = "0x18075C570", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5C4E2A0", Offset = "0x5C4D6A0", VA = "0x185C4E2A0")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5C4E220", Offset = "0x5C4D620", VA = "0x185C4E220")]
		public void JILBMBBBJLK(MutableOverridableDefaultableObscuredBool LJIBJAOOGGF)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, BBAMKHOIJLK> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x3FDCEC0", Offset = "0x3FDC2C0", VA = "0x183FDCEC0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x3FDCFF0", Offset = "0x3FDC3F0", VA = "0x183FDCFF0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3459D50", Offset = "0x3459150", VA = "0x183459D50")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3FDCEA0", Offset = "0x3FDC2A0", VA = "0x183FDCEA0")]
		public SerializedMutableOverridableObscuredEnum(bool MPOEHKFOOFJ, TObsEnum EOHMJBFGDPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3FDCC40", Offset = "0x3FDC040", VA = "0x183FDCC40", Slot = "18")]
		public sealed override BBAMKHOIJLK MNBCFLMIDLJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3FDCD30", Offset = "0x3FDC130", VA = "0x183FDCD30", Slot = "19")]
		public sealed override void NMBGAOPKONJ(BBAMKHOIJLK KEMKENCGIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3FDCB60", Offset = "0x3FDBF60", VA = "0x183FDCB60", Slot = "20")]
		public sealed override void DIEMGFGKJCB(byte[] CIHBJOGNBAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3FDCE30", Offset = "0x3FDC230", VA = "0x183FDCE30", Slot = "17")]
		public sealed override void OAFECOOGBFN()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, OKGIIOIGLBL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x5C4EB60", Offset = "0x5C4DF60", VA = "0x185C4EB60", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x5C4EBA0", Offset = "0x5C4DFA0", VA = "0x185C4EBA0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5C4EAC0", Offset = "0x5C4DEC0", VA = "0x185C4EAC0")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5C4EA60", Offset = "0x5C4DE60", VA = "0x185C4EA60")]
		public MutableOverridableListObscuredString(bool MPOEHKFOOFJ, List<ObscuredString> EOHMJBFGDPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5C4E9C0", Offset = "0x5C4DDC0", VA = "0x185C4E9C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5C4E930", Offset = "0x5C4DD30", VA = "0x185C4E930", Slot = "17")]
		public override void OAFECOOGBFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5C4E310", Offset = "0x5C4D710", VA = "0x185C4E310", Slot = "20")]
		public override void DIEMGFGKJCB(byte[] CIHBJOGNBAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5C4E5D0", Offset = "0x5C4D9D0", VA = "0x185C4E5D0", Slot = "19")]
		public override void NMBGAOPKONJ(OKGIIOIGLBL KEMKENCGIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5C4E3F0", Offset = "0x5C4D7F0", VA = "0x185C4E3F0", Slot = "18")]
		public override OKGIIOIGLBL MNBCFLMIDLJ()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : IHHPEFCHMDK<Vector3>, IDEMGGHKMCK
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
			[Cpp2IlInjected.Address(RVA = "0x1926750", Offset = "0x1925B50", VA = "0x181926750", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5C4FAF0", Offset = "0x5C4EEF0", VA = "0x185C4FAF0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x395DC90", Offset = "0x395D090", VA = "0x18395DC90", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3CC0850", Offset = "0x3CBFC50", VA = "0x183CC0850")]
		public OverridableVector3(Vector3 EOHMJBFGDPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5C4FA50", Offset = "0x5C4EE50", VA = "0x185C4FA50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5C4FA30", Offset = "0x5C4EE30", VA = "0x185C4FA30")]
		public static OverridableVector3 BNPEICKPPJA(Vector3 PGHIMEILAGJ)
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
