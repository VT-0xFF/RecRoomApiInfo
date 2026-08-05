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
public interface HIAFPJGHOCF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool JGDPNLCCMKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object EEHMNEKBHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LLFLPPIDMKF<T> : HIAFPJGHOCF
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T PENMJFOMGMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface JKBABMHBMGE<T> : LLFLPPIDMKF<T>, HIAFPJGHOCF
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool JGDPNLCCMKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T PENMJFOMGMH
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
public interface IKNKEALJOLP<T> : JKBABMHBMGE<T>, LLFLPPIDMKF<T>, HIAFPJGHOCF
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool EHLHHGPOHHG
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
	public struct OverridableInt : LLFLPPIDMKF<int>, HIAFPJGHOCF
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
			[Cpp2IlInjected.Address(RVA = "0x18FABC0", Offset = "0x18F93C0", VA = "0x1818FABC0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5CA9E30", Offset = "0x5CA8630", VA = "0x185CA9E30", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x1FBE230", Offset = "0x1FBCA30", VA = "0x181FBE230", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9D90", Offset = "0x5CA8590", VA = "0x185CA9D90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : LLFLPPIDMKF<string>, HIAFPJGHOCF
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
			[Cpp2IlInjected.Address(RVA = "0x18FABC0", Offset = "0x18F93C0", VA = "0x1818FABC0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x98F9E0", Offset = "0x98E1E0", VA = "0x18098F9E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x98F9E0", Offset = "0x98E1E0", VA = "0x18098F9E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9E80", Offset = "0x5CA8680", VA = "0x185CA9E80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : JKBABMHBMGE<InnerType>, LLFLPPIDMKF<InnerType>, HIAFPJGHOCF where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool JGDPNLCCMKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType PENMJFOMGMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object EEHMNEKBHCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x3B8E780", Offset = "0x3B8CF80", VA = "0x183B8E780", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3B8E440", Offset = "0x3B8CC40", VA = "0x183B8E440")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3B8E470", Offset = "0x3B8CC70", VA = "0x183B8E470")]
		public MutableOverridableBase(bool LCEIELLCABO, [NotNull] InnerType FKKGMPDEPMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3B8E380", Offset = "0x3B8CB80", VA = "0x183B8E380", Slot = "15")]
		public void IOCBHDGBGCL(LLFLPPIDMKF<InnerType> JBNDCJNMOID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3B8DED0", Offset = "0x3B8C6D0", VA = "0x183B8DED0", Slot = "16")]
		public void APFJFNBJOAO(LLFLPPIDMKF<InnerType> IFHFGCDLDEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3B8E050", Offset = "0x3B8C850", VA = "0x183B8E050", Slot = "17")]
		public virtual void FCKDKLKEHNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType CKFLEABPNCE();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void BDDLLMJPKHE(ProtobufType GMCDBPEJHDM);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void IEOFDEHKBLD(byte[] ABDPDJEKNOI);
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
			[Cpp2IlInjected.Address(RVA = "0x7B39F0", Offset = "0x7B21F0", VA = "0x1807B39F0", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x89BFC0", Offset = "0x89A7C0", VA = "0x18089BFC0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1806560", Offset = "0x1804D60", VA = "0x181806560", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x302DE60", Offset = "0x302C660", VA = "0x18302DE60")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3882010", Offset = "0x3880810", VA = "0x183882010")]
		public SerializedMutableOverridableBase(bool LCEIELLCABO, InnerType FKKGMPDEPMA)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, EGCDJGJAKEM>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9CC0", Offset = "0x5CA84C0", VA = "0x185CA9CC0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9D20", Offset = "0x5CA8520", VA = "0x185CA9D20")]
		public MutableOverridableObscuredInt(bool LCEIELLCABO, ObscuredInt FKKGMPDEPMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9BF0", Offset = "0x5CA83F0", VA = "0x185CA9BF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9B10", Offset = "0x5CA8310", VA = "0x185CA9B10", Slot = "20")]
		public override void IEOFDEHKBLD(byte[] ABDPDJEKNOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9980", Offset = "0x5CA8180", VA = "0x185CA9980", Slot = "19")]
		public override void BDDLLMJPKHE(EGCDJGJAKEM GMCDBPEJHDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9A30", Offset = "0x5CA8230", VA = "0x185CA9A30", Slot = "18")]
		public override EGCDJGJAKEM CKFLEABPNCE()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, HCDMLKFMMIC>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5CA98B0", Offset = "0x5CA80B0", VA = "0x185CA98B0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9910", Offset = "0x5CA8110", VA = "0x185CA9910")]
		public MutableOverridableObscuredFloat(bool LCEIELLCABO, ObscuredFloat FKKGMPDEPMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5CA97E0", Offset = "0x5CA7FE0", VA = "0x185CA97E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9700", Offset = "0x5CA7F00", VA = "0x185CA9700", Slot = "20")]
		public override void IEOFDEHKBLD(byte[] ABDPDJEKNOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9550", Offset = "0x5CA7D50", VA = "0x185CA9550", Slot = "19")]
		public override void BDDLLMJPKHE(HCDMLKFMMIC GMCDBPEJHDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9610", Offset = "0x5CA7E10", VA = "0x185CA9610", Slot = "18")]
		public override HCDMLKFMMIC CKFLEABPNCE()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, KPIDLPGBEPB>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8760", Offset = "0x5CA6F60", VA = "0x185CA8760")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5CA94E0", Offset = "0x5CA7CE0", VA = "0x185CA94E0")]
		public MutableOverridableObscuredBool(bool LCEIELLCABO, ObscuredBool FKKGMPDEPMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9410", Offset = "0x5CA7C10", VA = "0x185CA9410", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5CA92A0", Offset = "0x5CA7AA0", VA = "0x185CA92A0", Slot = "20")]
		public override void IEOFDEHKBLD(byte[] ABDPDJEKNOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5CA90F0", Offset = "0x5CA78F0", VA = "0x185CA90F0", Slot = "19")]
		public override void BDDLLMJPKHE(KPIDLPGBEPB GMCDBPEJHDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5CA91B0", Offset = "0x5CA79B0", VA = "0x185CA91B0", Slot = "18")]
		public override KPIDLPGBEPB CKFLEABPNCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9380", Offset = "0x5CA7B80", VA = "0x185CA9380", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, IKNKEALJOLP<ObscuredBool>, JKBABMHBMGE<ObscuredBool>, LLFLPPIDMKF<ObscuredBool>, HIAFPJGHOCF
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x76E480", Offset = "0x76CC80", VA = "0x18076E480", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x76E4A0", Offset = "0x76CCA0", VA = "0x18076E4A0", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8760", Offset = "0x5CA6F60", VA = "0x185CA8760")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5CA86E0", Offset = "0x5CA6EE0", VA = "0x185CA86E0")]
		public void IOCBHDGBGCL(MutableOverridableDefaultableObscuredBool IFHFGCDLDEA)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, EGCDJGJAKEM> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x3FA6AE0", Offset = "0x3FA52E0", VA = "0x183FA6AE0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x3FA6C10", Offset = "0x3FA5410", VA = "0x183FA6C10", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3407480", Offset = "0x3405C80", VA = "0x183407480")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3FA6AC0", Offset = "0x3FA52C0", VA = "0x183FA6AC0")]
		public SerializedMutableOverridableObscuredEnum(bool LCEIELLCABO, TObsEnum FKKGMPDEPMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3FA6880", Offset = "0x3FA5080", VA = "0x183FA6880", Slot = "18")]
		public sealed override EGCDJGJAKEM CKFLEABPNCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3FA6780", Offset = "0x3FA4F80", VA = "0x183FA6780", Slot = "19")]
		public sealed override void BDDLLMJPKHE(EGCDJGJAKEM GMCDBPEJHDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3FA69E0", Offset = "0x3FA51E0", VA = "0x183FA69E0", Slot = "20")]
		public sealed override void IEOFDEHKBLD(byte[] ABDPDJEKNOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3FA6970", Offset = "0x3FA5170", VA = "0x183FA6970", Slot = "17")]
		public sealed override void FCKDKLKEHNJ()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, OKPOGOKLGOB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x5CA9020", Offset = "0x5CA7820", VA = "0x185CA9020", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x5CA9060", Offset = "0x5CA7860", VA = "0x185CA9060", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8F80", Offset = "0x5CA7780", VA = "0x185CA8F80")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8F20", Offset = "0x5CA7720", VA = "0x185CA8F20")]
		public MutableOverridableListObscuredString(bool LCEIELLCABO, List<ObscuredString> FKKGMPDEPMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8E80", Offset = "0x5CA7680", VA = "0x185CA8E80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8D10", Offset = "0x5CA7510", VA = "0x185CA8D10", Slot = "17")]
		public override void FCKDKLKEHNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8DA0", Offset = "0x5CA75A0", VA = "0x185CA8DA0", Slot = "20")]
		public override void IEOFDEHKBLD(byte[] ABDPDJEKNOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5CA87D0", Offset = "0x5CA6FD0", VA = "0x185CA87D0", Slot = "19")]
		public override void BDDLLMJPKHE(OKPOGOKLGOB GMCDBPEJHDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5CA8B30", Offset = "0x5CA7330", VA = "0x185CA8B30", Slot = "18")]
		public override OKPOGOKLGOB CKFLEABPNCE()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : LLFLPPIDMKF<Vector3>, HIAFPJGHOCF
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
			[Cpp2IlInjected.Address(RVA = "0x18FABC0", Offset = "0x18F93C0", VA = "0x1818FABC0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5CA9FB0", Offset = "0x5CA87B0", VA = "0x185CA9FB0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x38FFB40", Offset = "0x38FE340", VA = "0x1838FFB40", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3C90330", Offset = "0x3C8EB30", VA = "0x183C90330")]
		public OverridableVector3(Vector3 FKKGMPDEPMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9F10", Offset = "0x5CA8710", VA = "0x185CA9F10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9EF0", Offset = "0x5CA86F0", VA = "0x185CA9EF0")]
		public static OverridableVector3 FEBAGKLNOCP(Vector3 LLMHDPLKODA)
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
