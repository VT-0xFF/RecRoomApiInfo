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
public interface BHLOHKICABJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DDPLMFCDJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object CCGEMADDHOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IJMCEKLHDHP<T> : BHLOHKICABJ
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T KCKILJPPPGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface JFCALNJPHMB<T> : global::IJMCEKLHDHP<T>, BHLOHKICABJ
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool DDPLMFCDJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T KCKILJPPPGI
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
public interface OBJFCJKJKLP<T> : global::JFCALNJPHMB<T>, global::IJMCEKLHDHP<T>, BHLOHKICABJ
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool KOBLMPBFMAD
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
	public struct OverridableInt : global::IJMCEKLHDHP<int>, BHLOHKICABJ
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
			[Cpp2IlInjected.Address(RVA = "0x9159F0", Offset = "0x9147F0", VA = "0x1809159F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6B0FCD0", Offset = "0x6B0EAD0", VA = "0x186B0FCD0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x90B640", Offset = "0x90A440", VA = "0x18090B640", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6B0FC30", Offset = "0x6B0EA30", VA = "0x186B0FC30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : global::IJMCEKLHDHP<string>, BHLOHKICABJ
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
			[Cpp2IlInjected.Address(RVA = "0x9159F0", Offset = "0x9147F0", VA = "0x1809159F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7979D0", Offset = "0x7967D0", VA = "0x1807979D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7979D0", Offset = "0x7967D0", VA = "0x1807979D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6B0FD20", Offset = "0x6B0EB20", VA = "0x186B0FD20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : global::JFCALNJPHMB<InnerType>, global::IJMCEKLHDHP<InnerType>, BHLOHKICABJ where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool DDPLMFCDJJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType KCKILJPPPGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object CCGEMADDHOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2A30A50", Offset = "0x2A2F850", VA = "0x182A30A50", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x31A6A80", Offset = "0x31A5880", VA = "0x1831A6A80")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x31A6B40", Offset = "0x31A5940", VA = "0x1831A6B40")]
		public MutableOverridableBase(bool OICJFLOHMGK, [NotNull] InnerType MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x31A5FF0", Offset = "0x31A4DF0", VA = "0x1831A5FF0", Slot = "15")]
		public void FBJCAOOLMCP(global::IJMCEKLHDHP<InnerType> FNBOMANHCNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x31A64C0", Offset = "0x31A52C0", VA = "0x1831A64C0", Slot = "16")]
		public void FGNHAFDBLPE(global::IJMCEKLHDHP<InnerType> IDBPJJAKCBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x31A6920", Offset = "0x31A5720", VA = "0x1831A6920", Slot = "17")]
		public virtual void JJEDLPKLPPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType ACLPGJFJIHM();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void DCLJNNJDPJI(ProtobufType EJCCAPEIJHK);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void LJDKIFFOLPJ(byte[] NPFGKPBMKPF);
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
			[Cpp2IlInjected.Address(RVA = "0x745880", Offset = "0x744680", VA = "0x180745880", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7458A0", Offset = "0x7446A0", VA = "0x1807458A0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1CA2AB0", Offset = "0x1CA18B0", VA = "0x181CA2AB0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x168F9D0", Offset = "0x168E7D0", VA = "0x18168F9D0")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2BFEEA0", Offset = "0x2BFDCA0", VA = "0x182BFEEA0")]
		public SerializedMutableOverridableBase(bool OICJFLOHMGK, InnerType MGFMONLLLPD)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, NMFMCENFOBK>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6B0FBD0", Offset = "0x6B0E9D0", VA = "0x186B0FBD0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6B0FB60", Offset = "0x6B0E960", VA = "0x186B0FB60")]
		public MutableOverridableObscuredInt(bool OICJFLOHMGK, ObscuredInt MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6B0FA90", Offset = "0x6B0E890", VA = "0x186B0FA90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6B0F990", Offset = "0x6B0E790", VA = "0x186B0F990", Slot = "20")]
		public override void LJDKIFFOLPJ(byte[] NPFGKPBMKPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6B0F8D0", Offset = "0x6B0E6D0", VA = "0x186B0F8D0", Slot = "19")]
		public override void DCLJNNJDPJI(NMFMCENFOBK EJCCAPEIJHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6B0F7F0", Offset = "0x6B0E5F0", VA = "0x186B0F7F0", Slot = "18")]
		public override NMFMCENFOBK ACLPGJFJIHM()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, LPHICEBOOPI>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6B0F720", Offset = "0x6B0E520", VA = "0x186B0F720")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6B0F780", Offset = "0x6B0E580", VA = "0x186B0F780")]
		public MutableOverridableObscuredFloat(bool OICJFLOHMGK, ObscuredFloat MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6B0F650", Offset = "0x6B0E450", VA = "0x186B0F650", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6B0F550", Offset = "0x6B0E350", VA = "0x186B0F550", Slot = "20")]
		public override void LJDKIFFOLPJ(byte[] NPFGKPBMKPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6B0F480", Offset = "0x6B0E280", VA = "0x186B0F480", Slot = "19")]
		public override void DCLJNNJDPJI(LPHICEBOOPI EJCCAPEIJHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6B0F390", Offset = "0x6B0E190", VA = "0x186B0F390", Slot = "18")]
		public override LPHICEBOOPI ACLPGJFJIHM()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, LDONKFFCEMB>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6B0E650", Offset = "0x6B0D450", VA = "0x186B0E650")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6B0F320", Offset = "0x6B0E120", VA = "0x186B0F320")]
		public MutableOverridableObscuredBool(bool OICJFLOHMGK, ObscuredBool MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6B0F250", Offset = "0x6B0E050", VA = "0x186B0F250", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6B0F110", Offset = "0x6B0DF10", VA = "0x186B0F110", Slot = "20")]
		public override void LJDKIFFOLPJ(byte[] NPFGKPBMKPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6B0F050", Offset = "0x6B0DE50", VA = "0x186B0F050", Slot = "19")]
		public override void DCLJNNJDPJI(LDONKFFCEMB EJCCAPEIJHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6B0EF70", Offset = "0x6B0DD70", VA = "0x186B0EF70", Slot = "18")]
		public override LDONKFFCEMB ACLPGJFJIHM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6B0F210", Offset = "0x6B0E010", VA = "0x186B0F210", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, global::OBJFCJKJKLP<ObscuredBool>, global::JFCALNJPHMB<ObscuredBool>, global::IJMCEKLHDHP<ObscuredBool>, BHLOHKICABJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x75C560", Offset = "0x75B360", VA = "0x18075C560", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7D64C0", Offset = "0x7D52C0", VA = "0x1807D64C0", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6B0E650", Offset = "0x6B0D450", VA = "0x186B0E650")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6B0E5D0", Offset = "0x6B0D3D0", VA = "0x186B0E5D0")]
		public void FBJCAOOLMCP(MutableOverridableDefaultableObscuredBool IDBPJJAKCBN)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, NMFMCENFOBK> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x3A1A600", Offset = "0x3A19400", VA = "0x183A1A600", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x3A1A6E0", Offset = "0x3A194E0", VA = "0x183A1A6E0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x20086F0", Offset = "0x20074F0", VA = "0x1820086F0")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3A1A5D0", Offset = "0x3A193D0", VA = "0x183A1A5D0")]
		public SerializedMutableOverridableObscuredEnum(TObsEnum MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2C008A0", Offset = "0x2BFF6A0", VA = "0x182C008A0")]
		public SerializedMutableOverridableObscuredEnum(bool OICJFLOHMGK, TObsEnum MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3A1A2B0", Offset = "0x3A190B0", VA = "0x183A1A2B0", Slot = "18")]
		public sealed override NMFMCENFOBK ACLPGJFJIHM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3A1A360", Offset = "0x3A19160", VA = "0x183A1A360", Slot = "19")]
		public sealed override void DCLJNNJDPJI(NMFMCENFOBK EJCCAPEIJHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3A1A4D0", Offset = "0x3A192D0", VA = "0x183A1A4D0", Slot = "20")]
		public sealed override void LJDKIFFOLPJ(byte[] NPFGKPBMKPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3A1A470", Offset = "0x3A19270", VA = "0x183A1A470", Slot = "17")]
		public sealed override void JJEDLPKLPPA()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, MEENECLELCF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6B0EEA0", Offset = "0x6B0DCA0", VA = "0x186B0EEA0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6B0EEE0", Offset = "0x6B0DCE0", VA = "0x186B0EEE0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6B0EDB0", Offset = "0x6B0DBB0", VA = "0x186B0EDB0")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6B0EE40", Offset = "0x6B0DC40", VA = "0x186B0EE40")]
		public MutableOverridableListObscuredString(bool OICJFLOHMGK, List<ObscuredString> MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6B0ED10", Offset = "0x6B0DB10", VA = "0x186B0ED10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6B0EBA0", Offset = "0x6B0D9A0", VA = "0x186B0EBA0", Slot = "17")]
		public override void JJEDLPKLPPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6B0EC10", Offset = "0x6B0DA10", VA = "0x186B0EC10", Slot = "20")]
		public override void LJDKIFFOLPJ(byte[] NPFGKPBMKPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6B0E880", Offset = "0x6B0D680", VA = "0x186B0E880", Slot = "19")]
		public override void DCLJNNJDPJI(MEENECLELCF EJCCAPEIJHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6B0E6C0", Offset = "0x6B0D4C0", VA = "0x186B0E6C0", Slot = "18")]
		public override MEENECLELCF ACLPGJFJIHM()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : global::IJMCEKLHDHP<Vector3>, BHLOHKICABJ
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
			[Cpp2IlInjected.Address(RVA = "0x9159F0", Offset = "0x9147F0", VA = "0x1809159F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6B0FE70", Offset = "0x6B0EC70", VA = "0x186B0FE70", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x2569570", Offset = "0x2568370", VA = "0x182569570", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6B0FE50", Offset = "0x6B0EC50", VA = "0x186B0FE50")]
		public OverridableVector3(Vector3 MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6B0FDB0", Offset = "0x6B0EBB0", VA = "0x186B0FDB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6B0FD90", Offset = "0x6B0EB90", VA = "0x186B0FD90")]
		public static OverridableVector3 JMLJLLKELMG(Vector3 MMAFFACGBGF)
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
