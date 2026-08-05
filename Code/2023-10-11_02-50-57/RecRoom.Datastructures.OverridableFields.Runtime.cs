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
public interface ODDOOGKFLNF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DEBIPILIDMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object PLPMHMAPIOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KAHBNOGOPIO<T> : ODDOOGKFLNF
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T GMPOHOAMMIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KIJILMEIFOD<T> : KAHBNOGOPIO<T>, ODDOOGKFLNF
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool DEBIPILIDMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T GMPOHOAMMIO
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
public interface IBFJJLJDJDO<T> : KIJILMEIFOD<T>, KAHBNOGOPIO<T>, ODDOOGKFLNF
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool NADPEMKDCMB
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
	public struct OverridableInt : KAHBNOGOPIO<int>, ODDOOGKFLNF
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
			[Cpp2IlInjected.Address(RVA = "0x18F63F0", Offset = "0x18F51F0", VA = "0x1818F63F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5CA9AC0", Offset = "0x5CA88C0", VA = "0x185CA9AC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x1FBBF30", Offset = "0x1FBAD30", VA = "0x181FBBF30", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9A20", Offset = "0x5CA8820", VA = "0x185CA9A20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : KAHBNOGOPIO<string>, ODDOOGKFLNF
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
			[Cpp2IlInjected.Address(RVA = "0x18F63F0", Offset = "0x18F51F0", VA = "0x1818F63F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x990730", Offset = "0x98F530", VA = "0x180990730", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x990730", Offset = "0x98F530", VA = "0x180990730", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9B10", Offset = "0x5CA8910", VA = "0x185CA9B10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : KIJILMEIFOD<InnerType>, KAHBNOGOPIO<InnerType>, ODDOOGKFLNF where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool DEBIPILIDMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType GMPOHOAMMIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object PLPMHMAPIOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x3BB9750", Offset = "0x3BB8550", VA = "0x183BB9750", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3BB9410", Offset = "0x3BB8210", VA = "0x183BB9410")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3BB9440", Offset = "0x3BB8240", VA = "0x183BB9440")]
		public MutableOverridableBase(bool DBAFAPHLOHL, [NotNull] InnerType GNLEHBFFNFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3BB90B0", Offset = "0x3BB7EB0", VA = "0x183BB90B0", Slot = "15")]
		public void OPDJHGNMKDA(KAHBNOGOPIO<InnerType> KHMLDGJNLOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3BB8FF0", Offset = "0x3BB7DF0", VA = "0x183BB8FF0", Slot = "16")]
		public void KBCPIACFDGK(KAHBNOGOPIO<InnerType> MFMJJEFODHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3BB8B40", Offset = "0x3BB7940", VA = "0x183BB8B40", Slot = "17")]
		public virtual void AOMGIBAKPFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType MFFIMDELKOD();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void NBNLMDDJBFN(ProtobufType CGEOMLBOPJN);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void GNEOGAPKHOD(byte[] AFCEEAAHIML);
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
			[Cpp2IlInjected.Address(RVA = "0x7B46A0", Offset = "0x7B34A0", VA = "0x1807B46A0", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8A3500", Offset = "0x8A2300", VA = "0x1808A3500", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1807250", Offset = "0x1806050", VA = "0x181807250", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x33CC3A0", Offset = "0x33CB1A0", VA = "0x1833CC3A0")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3816280", Offset = "0x3815080", VA = "0x183816280")]
		public SerializedMutableOverridableBase(bool DBAFAPHLOHL, InnerType GNLEHBFFNFG)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, IEKPKHIHACA>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9950", Offset = "0x5CA8750", VA = "0x185CA9950")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5CA99B0", Offset = "0x5CA87B0", VA = "0x185CA99B0")]
		public MutableOverridableObscuredInt(bool DBAFAPHLOHL, ObscuredInt GNLEHBFFNFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9880", Offset = "0x5CA8680", VA = "0x185CA9880", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9610", Offset = "0x5CA8410", VA = "0x185CA9610", Slot = "20")]
		public override void GNEOGAPKHOD(byte[] AFCEEAAHIML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5CA97D0", Offset = "0x5CA85D0", VA = "0x185CA97D0", Slot = "19")]
		public override void NBNLMDDJBFN(IEKPKHIHACA CGEOMLBOPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5CA96F0", Offset = "0x5CA84F0", VA = "0x185CA96F0", Slot = "18")]
		public override IEKPKHIHACA MFFIMDELKOD()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, PJKFKMOJAFL>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9540", Offset = "0x5CA8340", VA = "0x185CA9540")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5CA95A0", Offset = "0x5CA83A0", VA = "0x185CA95A0")]
		public MutableOverridableObscuredFloat(bool DBAFAPHLOHL, ObscuredFloat GNLEHBFFNFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9470", Offset = "0x5CA8270", VA = "0x185CA9470", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5CA91E0", Offset = "0x5CA7FE0", VA = "0x185CA91E0", Slot = "20")]
		public override void GNEOGAPKHOD(byte[] AFCEEAAHIML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5CA93B0", Offset = "0x5CA81B0", VA = "0x185CA93B0", Slot = "19")]
		public override void NBNLMDDJBFN(PJKFKMOJAFL CGEOMLBOPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5CA92C0", Offset = "0x5CA80C0", VA = "0x185CA92C0", Slot = "18")]
		public override PJKFKMOJAFL MFFIMDELKOD()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, DICFOBFCAFN>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5CA83F0", Offset = "0x5CA71F0", VA = "0x185CA83F0")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9170", Offset = "0x5CA7F70", VA = "0x185CA9170")]
		public MutableOverridableObscuredBool(bool DBAFAPHLOHL, ObscuredBool GNLEHBFFNFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5CA90A0", Offset = "0x5CA7EA0", VA = "0x185CA90A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8D80", Offset = "0x5CA7B80", VA = "0x185CA8D80", Slot = "20")]
		public override void GNEOGAPKHOD(byte[] AFCEEAAHIML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8F50", Offset = "0x5CA7D50", VA = "0x185CA8F50", Slot = "19")]
		public override void NBNLMDDJBFN(DICFOBFCAFN CGEOMLBOPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8E60", Offset = "0x5CA7C60", VA = "0x185CA8E60", Slot = "18")]
		public override DICFOBFCAFN MFFIMDELKOD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9010", Offset = "0x5CA7E10", VA = "0x185CA9010", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, IBFJJLJDJDO<ObscuredBool>, KIJILMEIFOD<ObscuredBool>, KAHBNOGOPIO<ObscuredBool>, ODDOOGKFLNF
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x76B180", Offset = "0x769F80", VA = "0x18076B180", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x76B150", Offset = "0x769F50", VA = "0x18076B150", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5CA83F0", Offset = "0x5CA71F0", VA = "0x185CA83F0")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8370", Offset = "0x5CA7170", VA = "0x185CA8370")]
		public void OPDJHGNMKDA(MutableOverridableDefaultableObscuredBool MFMJJEFODHB)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, IEKPKHIHACA> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x3FF30B0", Offset = "0x3FF1EB0", VA = "0x183FF30B0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x3FF31E0", Offset = "0x3FF1FE0", VA = "0x183FF31E0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3463A30", Offset = "0x3462830", VA = "0x183463A30")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3FF3090", Offset = "0x3FF1E90", VA = "0x183FF3090")]
		public SerializedMutableOverridableObscuredEnum(bool DBAFAPHLOHL, TObsEnum GNLEHBFFNFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3FF2EA0", Offset = "0x3FF1CA0", VA = "0x183FF2EA0", Slot = "18")]
		public sealed override IEKPKHIHACA MFFIMDELKOD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3FF2F90", Offset = "0x3FF1D90", VA = "0x183FF2F90", Slot = "19")]
		public sealed override void NBNLMDDJBFN(IEKPKHIHACA CGEOMLBOPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3FF2DC0", Offset = "0x3FF1BC0", VA = "0x183FF2DC0", Slot = "20")]
		public sealed override void GNEOGAPKHOD(byte[] AFCEEAAHIML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3FF2D50", Offset = "0x3FF1B50", VA = "0x183FF2D50", Slot = "17")]
		public sealed override void AOMGIBAKPFH()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, DDPHPCEEGMM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x5CA8CB0", Offset = "0x5CA7AB0", VA = "0x185CA8CB0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x5CA8CF0", Offset = "0x5CA7AF0", VA = "0x185CA8CF0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8C10", Offset = "0x5CA7A10", VA = "0x185CA8C10")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8BB0", Offset = "0x5CA79B0", VA = "0x185CA8BB0")]
		public MutableOverridableListObscuredString(bool DBAFAPHLOHL, List<ObscuredString> GNLEHBFFNFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8B10", Offset = "0x5CA7910", VA = "0x185CA8B10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8460", Offset = "0x5CA7260", VA = "0x185CA8460", Slot = "17")]
		public override void AOMGIBAKPFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5CA84F0", Offset = "0x5CA72F0", VA = "0x185CA84F0", Slot = "20")]
		public override void GNEOGAPKHOD(byte[] AFCEEAAHIML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5CA87B0", Offset = "0x5CA75B0", VA = "0x185CA87B0", Slot = "19")]
		public override void NBNLMDDJBFN(DDPHPCEEGMM CGEOMLBOPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5CA85D0", Offset = "0x5CA73D0", VA = "0x185CA85D0", Slot = "18")]
		public override DDPHPCEEGMM MFFIMDELKOD()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : KAHBNOGOPIO<Vector3>, ODDOOGKFLNF
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
			[Cpp2IlInjected.Address(RVA = "0x18F63F0", Offset = "0x18F51F0", VA = "0x1818F63F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5CA9C40", Offset = "0x5CA8A40", VA = "0x185CA9C40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x391C8E0", Offset = "0x391B6E0", VA = "0x18391C8E0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3C75550", Offset = "0x3C74350", VA = "0x183C75550")]
		public OverridableVector3(Vector3 GNLEHBFFNFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9BA0", Offset = "0x5CA89A0", VA = "0x185CA9BA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9B80", Offset = "0x5CA8980", VA = "0x185CA9B80")]
		public static OverridableVector3 FMKGPFEKDFI(Vector3 AACJDNHHIME)
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
