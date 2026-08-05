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
public interface MNLAFBCGADI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NMNDHMKMLPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object JPGCJOBOCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CHCDPGGHPNM<T> : MNLAFBCGADI
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T OIHHNPGGOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EOOEBJOPFFA<T> : global::CHCDPGGHPNM<T>, MNLAFBCGADI
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool NMNDHMKMLPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T OIHHNPGGOMC
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
public interface BDCDAGMCBPA<T> : global::EOOEBJOPFFA<T>, global::CHCDPGGHPNM<T>, MNLAFBCGADI
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool JFIDOABPKLO
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
	public struct OverridableInt : global::CHCDPGGHPNM<int>, MNLAFBCGADI
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
			[Cpp2IlInjected.Address(RVA = "0xA16C50", Offset = "0xA15250", VA = "0x180A16C50", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x1D18400", Offset = "0x1D16A00", VA = "0x181D18400", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7F3C20", Offset = "0x7F2220", VA = "0x1807F3C20", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1D18360", Offset = "0x1D16960", VA = "0x181D18360", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : global::CHCDPGGHPNM<string>, MNLAFBCGADI
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
			[Cpp2IlInjected.Address(RVA = "0xA16C50", Offset = "0xA15250", VA = "0x180A16C50", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x72F7C0", Offset = "0x72DDC0", VA = "0x18072F7C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x72F7C0", Offset = "0x72DDC0", VA = "0x18072F7C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1D18450", Offset = "0x1D16A50", VA = "0x181D18450", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : global::EOOEBJOPFFA<InnerType>, global::CHCDPGGHPNM<InnerType>, MNLAFBCGADI where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool NMNDHMKMLPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType OIHHNPGGOMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object JPGCJOBOCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x3164130", Offset = "0x3162730", VA = "0x183164130", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3163EA0", Offset = "0x31624A0", VA = "0x183163EA0")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3163F60", Offset = "0x3162560", VA = "0x183163F60")]
		public MutableOverridableBase(bool NHONBHBKDKN, [NotNull] InnerType MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3163A10", Offset = "0x3162010", VA = "0x183163A10", Slot = "15")]
		public void KFEKBIEFPGG(global::CHCDPGGHPNM<InnerType> GFONDJPDBHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3163410", Offset = "0x3161A10", VA = "0x183163410", Slot = "16")]
		public void GFHPIODIGEI(global::CHCDPGGHPNM<InnerType> OANENNOJEBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3163900", Offset = "0x3161F00", VA = "0x183163900", Slot = "17")]
		public virtual void GJKIOCLBKIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType GHHCJJJIBMP();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void GEHHOKIJHFK(ProtobufType CCCHGKBILHH);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void OFNMJHJMOOK(byte[] CCBLJEBKJKO);
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
			[Cpp2IlInjected.Address(RVA = "0x7F09A0", Offset = "0x7EEFA0", VA = "0x1807F09A0", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7F09C0", Offset = "0x7EEFC0", VA = "0x1807F09C0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x27F4060", Offset = "0x27F2660", VA = "0x1827F4060", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x23564F0", Offset = "0x2354AF0", VA = "0x1823564F0")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x334FFD0", Offset = "0x334E5D0", VA = "0x18334FFD0")]
		public SerializedMutableOverridableBase(bool NHONBHBKDKN, InnerType MAKFNMHIJIF)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, NDJKFFANJMK>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1D18300", Offset = "0x1D16900", VA = "0x181D18300")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1D18290", Offset = "0x1D16890", VA = "0x181D18290")]
		public MutableOverridableObscuredInt(bool NHONBHBKDKN, ObscuredInt MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1D181C0", Offset = "0x1D167C0", VA = "0x181D181C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1D180C0", Offset = "0x1D166C0", VA = "0x181D180C0", Slot = "20")]
		public override void OFNMJHJMOOK(byte[] CCBLJEBKJKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1D17F20", Offset = "0x1D16520", VA = "0x181D17F20", Slot = "19")]
		public override void GEHHOKIJHFK(NDJKFFANJMK CCCHGKBILHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1D17FE0", Offset = "0x1D165E0", VA = "0x181D17FE0", Slot = "18")]
		public override NDJKFFANJMK GHHCJJJIBMP()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, NGIECCONJKB>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x1D17E50", Offset = "0x1D16450", VA = "0x181D17E50")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1D17EB0", Offset = "0x1D164B0", VA = "0x181D17EB0")]
		public MutableOverridableObscuredFloat(bool NHONBHBKDKN, ObscuredFloat MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1D17D80", Offset = "0x1D16380", VA = "0x181D17D80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1D17C80", Offset = "0x1D16280", VA = "0x181D17C80", Slot = "20")]
		public override void OFNMJHJMOOK(byte[] CCBLJEBKJKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1D17AC0", Offset = "0x1D160C0", VA = "0x181D17AC0", Slot = "19")]
		public override void GEHHOKIJHFK(NGIECCONJKB CCCHGKBILHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1D17B90", Offset = "0x1D16190", VA = "0x181D17B90", Slot = "18")]
		public override NGIECCONJKB GHHCJJJIBMP()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, FOFGGHKBEGD>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1D16DC0", Offset = "0x1D153C0", VA = "0x181D16DC0")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1D17A50", Offset = "0x1D16050", VA = "0x181D17A50")]
		public MutableOverridableObscuredBool(bool NHONBHBKDKN, ObscuredBool MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1D17980", Offset = "0x1D15F80", VA = "0x181D17980", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1D17880", Offset = "0x1D15E80", VA = "0x181D17880", Slot = "20")]
		public override void OFNMJHJMOOK(byte[] CCBLJEBKJKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1D176E0", Offset = "0x1D15CE0", VA = "0x181D176E0", Slot = "19")]
		public override void GEHHOKIJHFK(FOFGGHKBEGD CCCHGKBILHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1D177A0", Offset = "0x1D15DA0", VA = "0x181D177A0", Slot = "18")]
		public override FOFGGHKBEGD GHHCJJJIBMP()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, global::BDCDAGMCBPA<ObscuredBool>, global::EOOEBJOPFFA<ObscuredBool>, global::CHCDPGGHPNM<ObscuredBool>, MNLAFBCGADI
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8C3430", Offset = "0x8C1A30", VA = "0x1808C3430", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x9D2BB0", Offset = "0x9D11B0", VA = "0x1809D2BB0", Slot = "22")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1D16DC0", Offset = "0x1D153C0", VA = "0x181D16DC0")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1D16D40", Offset = "0x1D15340", VA = "0x181D16D40")]
		public void KFEKBIEFPGG(MutableOverridableDefaultableObscuredBool OANENNOJEBB)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, NDJKFFANJMK> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x3E36190", Offset = "0x3E34790", VA = "0x183E36190", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x3E36270", Offset = "0x3E34870", VA = "0x183E36270", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x329EAB0", Offset = "0x329D0B0", VA = "0x18329EAB0")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3E36160", Offset = "0x3E34760", VA = "0x183E36160")]
		public SerializedMutableOverridableObscuredEnum(TObsEnum MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3E36130", Offset = "0x3E34730", VA = "0x183E36130")]
		public SerializedMutableOverridableObscuredEnum(bool NHONBHBKDKN, TObsEnum MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3E35F20", Offset = "0x3E34520", VA = "0x183E35F20", Slot = "18")]
		public sealed override NDJKFFANJMK GHHCJJJIBMP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3E35E10", Offset = "0x3E34410", VA = "0x183E35E10", Slot = "19")]
		public sealed override void GEHHOKIJHFK(NDJKFFANJMK CCCHGKBILHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3E36030", Offset = "0x3E34630", VA = "0x183E36030", Slot = "20")]
		public sealed override void OFNMJHJMOOK(byte[] CCBLJEBKJKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3E35FD0", Offset = "0x3E345D0", VA = "0x183E35FD0", Slot = "17")]
		public sealed override void GJKIOCLBKIK()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, DMAEOMHDDEF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x1D17610", Offset = "0x1D15C10", VA = "0x181D17610", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x1D17650", Offset = "0x1D15C50", VA = "0x181D17650", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1D17520", Offset = "0x1D15B20", VA = "0x181D17520")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1D175B0", Offset = "0x1D15BB0", VA = "0x181D175B0")]
		public MutableOverridableListObscuredString(bool NHONBHBKDKN, List<ObscuredString> MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1D17480", Offset = "0x1D15A80", VA = "0x181D17480", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1D17310", Offset = "0x1D15910", VA = "0x181D17310", Slot = "17")]
		public override void GJKIOCLBKIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x1D17380", Offset = "0x1D15980", VA = "0x181D17380", Slot = "20")]
		public override void OFNMJHJMOOK(byte[] CCBLJEBKJKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1D16E30", Offset = "0x1D15430", VA = "0x181D16E30", Slot = "19")]
		public override void GEHHOKIJHFK(DMAEOMHDDEF CCCHGKBILHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1D17150", Offset = "0x1D15750", VA = "0x181D17150", Slot = "18")]
		public override DMAEOMHDDEF GHHCJJJIBMP()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : global::CHCDPGGHPNM<Vector3>, MNLAFBCGADI
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
			[Cpp2IlInjected.Address(RVA = "0xA16C50", Offset = "0xA15250", VA = "0x180A16C50", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x1D185A0", Offset = "0x1D16BA0", VA = "0x181D185A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x794520", Offset = "0x792B20", VA = "0x180794520", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1D18580", Offset = "0x1D16B80", VA = "0x181D18580")]
		public OverridableVector3(Vector3 MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1D184E0", Offset = "0x1D16AE0", VA = "0x181D184E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x1D184C0", Offset = "0x1D16AC0", VA = "0x181D184C0")]
		public static OverridableVector3 DGKBAOBECFH(Vector3 PHMPKLAMLAM)
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
