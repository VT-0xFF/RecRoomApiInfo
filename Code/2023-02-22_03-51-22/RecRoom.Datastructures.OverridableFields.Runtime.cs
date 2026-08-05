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
public interface HIPMOHBKPLK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool JEAKBMCAGNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object DMNBMALIBCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LBMGHNDGBCA<T> : HIPMOHBKPLK
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T ALAOEPGGPNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface DJBPDDEFDCI<T> : global::LBMGHNDGBCA<T>, HIPMOHBKPLK
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool JEAKBMCAGNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T ALAOEPGGPNI
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
public interface LFPALMFFKIG<T> : global::DJBPDDEFDCI<T>, global::LBMGHNDGBCA<T>, HIPMOHBKPLK
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool KGOFDPOGOEL
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
	public struct OverridableInt : global::LBMGHNDGBCA<int>, HIPMOHBKPLK
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
			[Cpp2IlInjected.Address(RVA = "0x89A960", Offset = "0x899B60", VA = "0x18089A960", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x647EEB0", Offset = "0x647E0B0", VA = "0x18647EEB0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x890590", Offset = "0x88F790", VA = "0x180890590", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x647EE10", Offset = "0x647E010", VA = "0x18647EE10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : global::LBMGHNDGBCA<string>, HIPMOHBKPLK
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
			[Cpp2IlInjected.Address(RVA = "0x89A960", Offset = "0x899B60", VA = "0x18089A960", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x71DB00", Offset = "0x71CD00", VA = "0x18071DB00", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x71DB00", Offset = "0x71CD00", VA = "0x18071DB00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x647EF00", Offset = "0x647E100", VA = "0x18647EF00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : global::DJBPDDEFDCI<InnerType>, global::LBMGHNDGBCA<InnerType>, HIPMOHBKPLK where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool JEAKBMCAGNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType ALAOEPGGPNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object DMNBMALIBCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x26843A0", Offset = "0x26835A0", VA = "0x1826843A0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2684110", Offset = "0x2683310", VA = "0x182684110")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x26841D0", Offset = "0x26833D0", VA = "0x1826841D0")]
		public MutableOverridableBase(bool KDHNCKPMHBN, [NotNull] InnerType JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2683D70", Offset = "0x2682F70", VA = "0x182683D70", Slot = "15")]
		public void POKINCNMBKJ(global::LBMGHNDGBCA<InnerType> NEMGEPEGIGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2683BB0", Offset = "0x2682DB0", VA = "0x182683BB0", Slot = "16")]
		public void JPMCEPOCADG(global::LBMGHNDGBCA<InnerType> IHIJPIJNLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2683680", Offset = "0x2682880", VA = "0x182683680", Slot = "17")]
		public virtual void FNNEKAKKIMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType JJKOFBNCPAP();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void HDKHDDIEOOG(ProtobufType LFJPDDCPGGF);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void PCNCOBFKLKF(byte[] PNGAGAFHLKO);
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
			[Cpp2IlInjected.Address(RVA = "0x6CB250", Offset = "0x6CA450", VA = "0x1806CB250", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6CB270", Offset = "0x6CA470", VA = "0x1806CB270", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1AF3250", Offset = "0x1AF2450", VA = "0x181AF3250", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1764C70", Offset = "0x1763E70", VA = "0x181764C70")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2545610", Offset = "0x2544810", VA = "0x182545610")]
		public SerializedMutableOverridableBase(bool KDHNCKPMHBN, InnerType JFBPNBNBHOE)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, NFBNDHPAOIC>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x647EDB0", Offset = "0x647DFB0", VA = "0x18647EDB0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x647ED40", Offset = "0x647DF40", VA = "0x18647ED40")]
		public MutableOverridableObscuredInt(bool KDHNCKPMHBN, ObscuredInt JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x647EC70", Offset = "0x647DE70", VA = "0x18647EC70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x647EB70", Offset = "0x647DD70", VA = "0x18647EB70", Slot = "20")]
		public override void PCNCOBFKLKF(byte[] PNGAGAFHLKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x647E9D0", Offset = "0x647DBD0", VA = "0x18647E9D0", Slot = "19")]
		public override void HDKHDDIEOOG(NFBNDHPAOIC LFJPDDCPGGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x647EA90", Offset = "0x647DC90", VA = "0x18647EA90", Slot = "18")]
		public override NFBNDHPAOIC JJKOFBNCPAP()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, DBKIILPBLNB>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x647E900", Offset = "0x647DB00", VA = "0x18647E900")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x647E960", Offset = "0x647DB60", VA = "0x18647E960")]
		public MutableOverridableObscuredFloat(bool KDHNCKPMHBN, ObscuredFloat JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x647E830", Offset = "0x647DA30", VA = "0x18647E830", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x647E730", Offset = "0x647D930", VA = "0x18647E730", Slot = "20")]
		public override void PCNCOBFKLKF(byte[] PNGAGAFHLKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x647E570", Offset = "0x647D770", VA = "0x18647E570", Slot = "19")]
		public override void HDKHDDIEOOG(DBKIILPBLNB LFJPDDCPGGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x647E640", Offset = "0x647D840", VA = "0x18647E640", Slot = "18")]
		public override DBKIILPBLNB JJKOFBNCPAP()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, PNKDOBDDJDF>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x647D830", Offset = "0x647CA30", VA = "0x18647D830")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x647E500", Offset = "0x647D700", VA = "0x18647E500")]
		public MutableOverridableObscuredBool(bool KDHNCKPMHBN, ObscuredBool JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x647E430", Offset = "0x647D630", VA = "0x18647E430", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x647E330", Offset = "0x647D530", VA = "0x18647E330", Slot = "20")]
		public override void PCNCOBFKLKF(byte[] PNGAGAFHLKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x647E150", Offset = "0x647D350", VA = "0x18647E150", Slot = "19")]
		public override void HDKHDDIEOOG(PNKDOBDDJDF LFJPDDCPGGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x647E210", Offset = "0x647D410", VA = "0x18647E210", Slot = "18")]
		public override PNKDOBDDJDF JJKOFBNCPAP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x647E2F0", Offset = "0x647D4F0", VA = "0x18647E2F0", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, global::LFPALMFFKIG<ObscuredBool>, global::DJBPDDEFDCI<ObscuredBool>, global::LBMGHNDGBCA<ObscuredBool>, HIPMOHBKPLK
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6E23D0", Offset = "0x6E15D0", VA = "0x1806E23D0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7F4AF0", Offset = "0x7F3CF0", VA = "0x1807F4AF0", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x647D830", Offset = "0x647CA30", VA = "0x18647D830")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x647D7B0", Offset = "0x647C9B0", VA = "0x18647D7B0")]
		public void POKINCNMBKJ(MutableOverridableDefaultableObscuredBool IHIJPIJNLJM)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, NFBNDHPAOIC> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x2FDD820", Offset = "0x2FDCA20", VA = "0x182FDD820", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x2FDD900", Offset = "0x2FDCB00", VA = "0x182FDD900", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x271E2C0", Offset = "0x271D4C0", VA = "0x18271E2C0")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2FDD7F0", Offset = "0x2FDC9F0", VA = "0x182FDD7F0")]
		public SerializedMutableOverridableObscuredEnum(TObsEnum JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2A20", Offset = "0x2BB1C20", VA = "0x182BB2A20")]
		public SerializedMutableOverridableObscuredEnum(bool KDHNCKPMHBN, TObsEnum JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2FDD640", Offset = "0x2FDC840", VA = "0x182FDD640", Slot = "18")]
		public sealed override NFBNDHPAOIC JJKOFBNCPAP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2FDD530", Offset = "0x2FDC730", VA = "0x182FDD530", Slot = "19")]
		public sealed override void HDKHDDIEOOG(NFBNDHPAOIC LFJPDDCPGGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2FDD6F0", Offset = "0x2FDC8F0", VA = "0x182FDD6F0", Slot = "20")]
		public sealed override void PCNCOBFKLKF(byte[] PNGAGAFHLKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2FDD4D0", Offset = "0x2FDC6D0", VA = "0x182FDD4D0", Slot = "17")]
		public sealed override void FNNEKAKKIMH()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, AFDEMDAAHAP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x647E080", Offset = "0x647D280", VA = "0x18647E080", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x647E0C0", Offset = "0x647D2C0", VA = "0x18647E0C0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x647DF90", Offset = "0x647D190", VA = "0x18647DF90")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x647E020", Offset = "0x647D220", VA = "0x18647E020")]
		public MutableOverridableListObscuredString(bool KDHNCKPMHBN, List<ObscuredString> JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x647DEF0", Offset = "0x647D0F0", VA = "0x18647DEF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x647D8A0", Offset = "0x647CAA0", VA = "0x18647D8A0", Slot = "17")]
		public override void FNNEKAKKIMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x647DDF0", Offset = "0x647CFF0", VA = "0x18647DDF0", Slot = "20")]
		public override void PCNCOBFKLKF(byte[] PNGAGAFHLKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x647D910", Offset = "0x647CB10", VA = "0x18647D910", Slot = "19")]
		public override void HDKHDDIEOOG(AFDEMDAAHAP LFJPDDCPGGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x647DC30", Offset = "0x647CE30", VA = "0x18647DC30", Slot = "18")]
		public override AFDEMDAAHAP JJKOFBNCPAP()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : global::LBMGHNDGBCA<Vector3>, HIPMOHBKPLK
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
			[Cpp2IlInjected.Address(RVA = "0x89A960", Offset = "0x899B60", VA = "0x18089A960", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x647F050", Offset = "0x647E250", VA = "0x18647F050", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x1CD6BF0", Offset = "0x1CD5DF0", VA = "0x181CD6BF0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x647F030", Offset = "0x647E230", VA = "0x18647F030")]
		public OverridableVector3(Vector3 JFBPNBNBHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x647EF90", Offset = "0x647E190", VA = "0x18647EF90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x647EF70", Offset = "0x647E170", VA = "0x18647EF70")]
		public static OverridableVector3 LOJIFGBJNLM(Vector3 GBADNLAFNJL)
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
