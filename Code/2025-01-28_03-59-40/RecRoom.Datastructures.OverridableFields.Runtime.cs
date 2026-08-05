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
public interface IFODGLOOFLO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FOBGNIDHKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object NNMHDMGCKNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EIABGAIOEBI<T> : IFODGLOOFLO
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T ELOFPHHKCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface JDJGGKLDEAG<T> : EIABGAIOEBI<T>, IFODGLOOFLO
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool FOBGNIDHKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T ELOFPHHKCIM
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
public interface DCAOHLNFCFH<T> : JDJGGKLDEAG<T>, EIABGAIOEBI<T>, IFODGLOOFLO
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool FBHDHKOMHHA
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
	public struct OverridableInt : EIABGAIOEBI<int>, IFODGLOOFLO
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
			[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5AC00", VA = "0x180D5BA00", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x71E8490", Offset = "0x71E7690", VA = "0x1871E8490", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2B3B3F0", Offset = "0x2B3A5F0", VA = "0x182B3B3F0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x71E83F0", Offset = "0x71E75F0", VA = "0x1871E83F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : EIABGAIOEBI<string>, IFODGLOOFLO
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
			[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5AC00", VA = "0x180D5BA00", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xC14800", Offset = "0xC13A00", VA = "0x180C14800", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xC14800", Offset = "0xC13A00", VA = "0x180C14800", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x71E84E0", Offset = "0x71E76E0", VA = "0x1871E84E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : JDJGGKLDEAG<InnerType>, EIABGAIOEBI<InnerType>, IFODGLOOFLO where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool FOBGNIDHKAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType ELOFPHHKCIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object NNMHDMGCKNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x26E8FD0", Offset = "0x26E81D0", VA = "0x1826E8FD0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4C63D20", Offset = "0x4C62F20", VA = "0x184C63D20")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4C63D50", Offset = "0x4C62F50", VA = "0x184C63D50")]
		public MutableOverridableBase(bool AJALJPFBHOD, [NotNull] InnerType OMEFCJCOLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4C63300", Offset = "0x4C62500", VA = "0x184C63300", Slot = "15")]
		public void FMKBLFPINMP(EIABGAIOEBI<InnerType> FCKHEFJCHLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4C639D0", Offset = "0x4C62BD0", VA = "0x184C639D0", Slot = "16")]
		public void KBOLCOBAECE(EIABGAIOEBI<InnerType> JAINJPLCLDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4C63BD0", Offset = "0x4C62DD0", VA = "0x184C63BD0", Slot = "17")]
		public virtual void OKECIINHNOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType ANLOANFCCPG();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void NNLHLJFDFPP(ProtobufType BKALFDDOLIH);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void JHEFACFOEDD(byte[] CHIHCHDNDDB);
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
			[Cpp2IlInjected.Address(RVA = "0xB24780", Offset = "0xB23980", VA = "0x180B24780", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xB24BA0", Offset = "0xB23DA0", VA = "0x180B24BA0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xC71880", Offset = "0xC70A80", VA = "0x180C71880", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x42DEC80", Offset = "0x42DDE80", VA = "0x1842DEC80")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x44E4C40", Offset = "0x44E3E40", VA = "0x1844E4C40")]
		public SerializedMutableOverridableBase(bool AJALJPFBHOD, InnerType OMEFCJCOLII)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, NKIMAANIJPG>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x71E8320", Offset = "0x71E7520", VA = "0x1871E8320")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x71E8380", Offset = "0x71E7580", VA = "0x1871E8380")]
		public MutableOverridableObscuredInt(bool AJALJPFBHOD, ObscuredInt OMEFCJCOLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x71E8250", Offset = "0x71E7450", VA = "0x1871E8250", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x71E80C0", Offset = "0x71E72C0", VA = "0x1871E80C0", Slot = "20")]
		public override void JHEFACFOEDD(byte[] CHIHCHDNDDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x71E81A0", Offset = "0x71E73A0", VA = "0x1871E81A0", Slot = "19")]
		public override void NNLHLJFDFPP(NKIMAANIJPG BKALFDDOLIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x71E7FE0", Offset = "0x71E71E0", VA = "0x1871E7FE0", Slot = "18")]
		public override NKIMAANIJPG ANLOANFCCPG()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, AFFKPOJFHAK>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x71E7F10", Offset = "0x71E7110", VA = "0x1871E7F10")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x71E7F70", Offset = "0x71E7170", VA = "0x1871E7F70")]
		public MutableOverridableObscuredFloat(bool AJALJPFBHOD, ObscuredFloat OMEFCJCOLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x71E7E40", Offset = "0x71E7040", VA = "0x1871E7E40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x71E7CA0", Offset = "0x71E6EA0", VA = "0x1871E7CA0", Slot = "20")]
		public override void JHEFACFOEDD(byte[] CHIHCHDNDDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x71E7D80", Offset = "0x71E6F80", VA = "0x1871E7D80", Slot = "19")]
		public override void NNLHLJFDFPP(AFFKPOJFHAK BKALFDDOLIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x71E7BB0", Offset = "0x71E6DB0", VA = "0x1871E7BB0", Slot = "18")]
		public override AFFKPOJFHAK ANLOANFCCPG()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, CNBFFHNNIOD>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x71E6DC0", Offset = "0x71E5FC0", VA = "0x1871E6DC0")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x71E7B40", Offset = "0x71E6D40", VA = "0x1871E7B40")]
		public MutableOverridableObscuredBool(bool AJALJPFBHOD, ObscuredBool OMEFCJCOLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x71E7A70", Offset = "0x71E6C70", VA = "0x1871E7A70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x71E7840", Offset = "0x71E6A40", VA = "0x1871E7840", Slot = "20")]
		public override void JHEFACFOEDD(byte[] CHIHCHDNDDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x71E7920", Offset = "0x71E6B20", VA = "0x1871E7920", Slot = "19")]
		public override void NNLHLJFDFPP(CNBFFHNNIOD BKALFDDOLIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x71E7750", Offset = "0x71E6950", VA = "0x1871E7750", Slot = "18")]
		public override CNBFFHNNIOD ANLOANFCCPG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x71E79E0", Offset = "0x71E6BE0", VA = "0x1871E79E0", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, DCAOHLNFCFH<ObscuredBool>, JDJGGKLDEAG<ObscuredBool>, EIABGAIOEBI<ObscuredBool>, IFODGLOOFLO
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8FB0D0", Offset = "0x8FA2D0", VA = "0x1808FB0D0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8FB090", Offset = "0x8FA290", VA = "0x1808FB090", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x71E6DC0", Offset = "0x71E5FC0", VA = "0x1871E6DC0")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x71E6D40", Offset = "0x71E5F40", VA = "0x1871E6D40")]
		public void FMKBLFPINMP(MutableOverridableDefaultableObscuredBool JAINJPLCLDO)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, NKIMAANIJPG> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x514B8A0", Offset = "0x514AAA0", VA = "0x18514B8A0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x514BA20", Offset = "0x514AC20", VA = "0x18514BA20", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3F22090", Offset = "0x3F21290", VA = "0x183F22090")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x514B860", Offset = "0x514AA60", VA = "0x18514B860")]
		public SerializedMutableOverridableObscuredEnum(bool AJALJPFBHOD, TObsEnum OMEFCJCOLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x514B510", Offset = "0x514A710", VA = "0x18514B510", Slot = "18")]
		public sealed override NKIMAANIJPG ANLOANFCCPG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x514B6E0", Offset = "0x514A8E0", VA = "0x18514B6E0", Slot = "19")]
		public sealed override void NNLHLJFDFPP(NKIMAANIJPG BKALFDDOLIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x514B600", Offset = "0x514A800", VA = "0x18514B600", Slot = "20")]
		public sealed override void JHEFACFOEDD(byte[] CHIHCHDNDDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x514B7E0", Offset = "0x514A9E0", VA = "0x18514B7E0", Slot = "17")]
		public sealed override void OKECIINHNOA()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, BINGOPMFNPP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x71E7680", Offset = "0x71E6880", VA = "0x1871E7680", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x71E76C0", Offset = "0x71E68C0", VA = "0x1871E76C0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x71E75E0", Offset = "0x71E67E0", VA = "0x1871E75E0")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x71E7580", Offset = "0x71E6780", VA = "0x1871E7580")]
		public MutableOverridableListObscuredString(bool AJALJPFBHOD, List<ObscuredString> OMEFCJCOLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x71E74E0", Offset = "0x71E66E0", VA = "0x1871E74E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x71E7450", Offset = "0x71E6650", VA = "0x1871E7450", Slot = "17")]
		public override void OKECIINHNOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x71E7010", Offset = "0x71E6210", VA = "0x1871E7010", Slot = "20")]
		public override void JHEFACFOEDD(byte[] CHIHCHDNDDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x71E70F0", Offset = "0x71E62F0", VA = "0x1871E70F0", Slot = "19")]
		public override void NNLHLJFDFPP(BINGOPMFNPP BKALFDDOLIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x71E6E30", Offset = "0x71E6030", VA = "0x1871E6E30", Slot = "18")]
		public override BINGOPMFNPP ANLOANFCCPG()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : EIABGAIOEBI<Vector3>, IFODGLOOFLO
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
			[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5AC00", VA = "0x180D5BA00", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x71E8610", Offset = "0x71E7810", VA = "0x1871E8610", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x49CB900", Offset = "0x49CAB00", VA = "0x1849CB900", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4D71270", Offset = "0x4D70470", VA = "0x184D71270")]
		public OverridableVector3(Vector3 OMEFCJCOLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x53D5DD0", Offset = "0x53D4FD0", VA = "0x1853D5DD0")]
		public OverridableVector3(bool AJALJPFBHOD, Vector3 OMEFCJCOLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x71E8570", Offset = "0x71E7770", VA = "0x1871E8570", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x71E8550", Offset = "0x71E7750", VA = "0x1871E8550")]
		public static OverridableVector3 KEDBNOKLEHE(Vector3 IAPIOFHOONE)
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
