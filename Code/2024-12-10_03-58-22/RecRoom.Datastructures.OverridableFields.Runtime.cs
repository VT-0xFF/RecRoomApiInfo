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
public interface IDFDHILCCOL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool HMKBFFMDCEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object CPHBOBDNJNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OGEGOBMAKHC<T> : IDFDHILCCOL
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T PPPKGAOABBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FHHFIHBELLF<T> : OGEGOBMAKHC<T>, IDFDHILCCOL
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool HMKBFFMDCEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T PPPKGAOABBC
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
public interface KBIOKJHNLJO<T> : FHHFIHBELLF<T>, OGEGOBMAKHC<T>, IDFDHILCCOL
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool JGJLMOIPLCH
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
	public struct OverridableInt : OGEGOBMAKHC<int>, IDFDHILCCOL
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
			[Cpp2IlInjected.Address(RVA = "0x919930", Offset = "0x918530", VA = "0x180919930", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6C0F8C0", Offset = "0x6C0E4C0", VA = "0x186C0F8C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2746650", Offset = "0x2745250", VA = "0x182746650", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F820", Offset = "0x6C0E420", VA = "0x186C0F820", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : OGEGOBMAKHC<string>, IDFDHILCCOL
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
			[Cpp2IlInjected.Address(RVA = "0x919930", Offset = "0x918530", VA = "0x180919930", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA644E0", Offset = "0xA630E0", VA = "0x180A644E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA644E0", Offset = "0xA630E0", VA = "0x180A644E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F910", Offset = "0x6C0E510", VA = "0x186C0F910", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : FHHFIHBELLF<InnerType>, OGEGOBMAKHC<InnerType>, IDFDHILCCOL where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool HMKBFFMDCEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType PPPKGAOABBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object CPHBOBDNJNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2304560", Offset = "0x2303160", VA = "0x182304560", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4632B10", Offset = "0x4631710", VA = "0x184632B10")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4632B40", Offset = "0x4631740", VA = "0x184632B40")]
		public MutableOverridableBase(bool EMFGOKFBDIK, [NotNull] InnerType CABLCDOIFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4632900", Offset = "0x4631500", VA = "0x184632900", Slot = "15")]
		public void MBHBMGCLFJG(OGEGOBMAKHC<InnerType> AMNGEABADMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4632320", Offset = "0x4630F20", VA = "0x184632320", Slot = "16")]
		public void GBKEAFBIGGC(OGEGOBMAKHC<InnerType> FDOEIPBMJJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4632AD0", Offset = "0x46316D0", VA = "0x184632AD0", Slot = "17")]
		public virtual void OMNFNMJPOGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType IADCMOOOFFG();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void MOADGEHHBGF(ProtobufType NIPMIPNNJPF);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void FPEKFCPFJDN(byte[] EIGODKHJPKK);
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
			[Cpp2IlInjected.Address(RVA = "0x935C80", Offset = "0x934880", VA = "0x180935C80", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xBA1690", Offset = "0xBA0290", VA = "0x180BA1690", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1F695F0", Offset = "0x1F681F0", VA = "0x181F695F0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3A5A620", Offset = "0x3A59220", VA = "0x183A5A620")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3E1EEA0", Offset = "0x3E1DAA0", VA = "0x183E1EEA0")]
		public SerializedMutableOverridableBase(bool EMFGOKFBDIK, InnerType CABLCDOIFFL)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, KKHFGCMDPGC>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F750", Offset = "0x6C0E350", VA = "0x186C0F750")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F7B0", Offset = "0x6C0E3B0", VA = "0x186C0F7B0")]
		public MutableOverridableObscuredInt(bool EMFGOKFBDIK, ObscuredInt CABLCDOIFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F680", Offset = "0x6C0E280", VA = "0x186C0F680", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F420", Offset = "0x6C0E020", VA = "0x186C0F420", Slot = "20")]
		public override void FPEKFCPFJDN(byte[] EIGODKHJPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F5D0", Offset = "0x6C0E1D0", VA = "0x186C0F5D0", Slot = "19")]
		public override void MOADGEHHBGF(KKHFGCMDPGC NIPMIPNNJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F4F0", Offset = "0x6C0E0F0", VA = "0x186C0F4F0", Slot = "18")]
		public override KKHFGCMDPGC IADCMOOOFFG()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, LPJCJJKKJDD>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F350", Offset = "0x6C0DF50", VA = "0x186C0F350")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F3B0", Offset = "0x6C0DFB0", VA = "0x186C0F3B0")]
		public MutableOverridableObscuredFloat(bool EMFGOKFBDIK, ObscuredFloat CABLCDOIFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F280", Offset = "0x6C0DE80", VA = "0x186C0F280", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F000", Offset = "0x6C0DC00", VA = "0x186C0F000", Slot = "20")]
		public override void FPEKFCPFJDN(byte[] EIGODKHJPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F1C0", Offset = "0x6C0DDC0", VA = "0x186C0F1C0", Slot = "19")]
		public override void MOADGEHHBGF(LPJCJJKKJDD NIPMIPNNJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F0D0", Offset = "0x6C0DCD0", VA = "0x186C0F0D0", Slot = "18")]
		public override LPJCJJKKJDD IADCMOOOFFG()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, GNDHAPJAJEA>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6C0E220", Offset = "0x6C0CE20", VA = "0x186C0E220")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6C0EF90", Offset = "0x6C0DB90", VA = "0x186C0EF90")]
		public MutableOverridableObscuredBool(bool EMFGOKFBDIK, ObscuredBool CABLCDOIFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6C0EEC0", Offset = "0x6C0DAC0", VA = "0x186C0EEC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6C0EBB0", Offset = "0x6C0D7B0", VA = "0x186C0EBB0", Slot = "20")]
		public override void FPEKFCPFJDN(byte[] EIGODKHJPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6C0ED70", Offset = "0x6C0D970", VA = "0x186C0ED70", Slot = "19")]
		public override void MOADGEHHBGF(GNDHAPJAJEA NIPMIPNNJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6C0EC80", Offset = "0x6C0D880", VA = "0x186C0EC80", Slot = "18")]
		public override GNDHAPJAJEA IADCMOOOFFG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6C0EE30", Offset = "0x6C0DA30", VA = "0x186C0EE30", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, KBIOKJHNLJO<ObscuredBool>, FHHFIHBELLF<ObscuredBool>, OGEGOBMAKHC<ObscuredBool>, IDFDHILCCOL
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x88C770", Offset = "0x88B370", VA = "0x18088C770", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x88C5E0", Offset = "0x88B1E0", VA = "0x18088C5E0", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6C0E220", Offset = "0x6C0CE20", VA = "0x186C0E220")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6C0E1A0", Offset = "0x6C0CDA0", VA = "0x186C0E1A0")]
		public void MBHBMGCLFJG(MutableOverridableDefaultableObscuredBool FDOEIPBMJJM)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, KKHFGCMDPGC> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x4B6D220", Offset = "0x4B6BE20", VA = "0x184B6D220", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x4B6D3A0", Offset = "0x4B6BFA0", VA = "0x184B6D3A0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3E20760", Offset = "0x3E1F360", VA = "0x183E20760")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4B6D1E0", Offset = "0x4B6BDE0", VA = "0x184B6D1E0")]
		public SerializedMutableOverridableObscuredEnum(bool EMFGOKFBDIK, TObsEnum CABLCDOIFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4B6CF70", Offset = "0x4B6BB70", VA = "0x184B6CF70", Slot = "18")]
		public sealed override KKHFGCMDPGC IADCMOOOFFG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4B6D060", Offset = "0x4B6BC60", VA = "0x184B6D060", Slot = "19")]
		public sealed override void MOADGEHHBGF(KKHFGCMDPGC NIPMIPNNJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4B6CE90", Offset = "0x4B6BA90", VA = "0x184B6CE90", Slot = "20")]
		public sealed override void FPEKFCPFJDN(byte[] EIGODKHJPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4B6D160", Offset = "0x4B6BD60", VA = "0x184B6D160", Slot = "17")]
		public sealed override void OMNFNMJPOGD()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, ANJKHOBILLA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6C0EAE0", Offset = "0x6C0D6E0", VA = "0x186C0EAE0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6C0EB20", Offset = "0x6C0D720", VA = "0x186C0EB20", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6C0EA40", Offset = "0x6C0D640", VA = "0x186C0EA40")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6C0E9E0", Offset = "0x6C0D5E0", VA = "0x186C0E9E0")]
		public MutableOverridableListObscuredString(bool EMFGOKFBDIK, List<ObscuredString> CABLCDOIFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6C0E940", Offset = "0x6C0D540", VA = "0x186C0E940", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6C0E8B0", Offset = "0x6C0D4B0", VA = "0x186C0E8B0", Slot = "17")]
		public override void OMNFNMJPOGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6C0E290", Offset = "0x6C0CE90", VA = "0x186C0E290", Slot = "20")]
		public override void FPEKFCPFJDN(byte[] EIGODKHJPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6C0E540", Offset = "0x6C0D140", VA = "0x186C0E540", Slot = "19")]
		public override void MOADGEHHBGF(ANJKHOBILLA NIPMIPNNJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6C0E360", Offset = "0x6C0CF60", VA = "0x186C0E360", Slot = "18")]
		public override ANJKHOBILLA IADCMOOOFFG()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : OGEGOBMAKHC<Vector3>, IDFDHILCCOL
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
			[Cpp2IlInjected.Address(RVA = "0x919930", Offset = "0x918530", VA = "0x180919930", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6C0FA40", Offset = "0x6C0E640", VA = "0x186C0FA40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x435CD30", Offset = "0x435B930", VA = "0x18435CD30", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x47627D0", Offset = "0x47613D0", VA = "0x1847627D0")]
		public OverridableVector3(Vector3 CABLCDOIFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4E08CD0", Offset = "0x4E078D0", VA = "0x184E08CD0")]
		public OverridableVector3(bool EMFGOKFBDIK, Vector3 CABLCDOIFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F9A0", Offset = "0x6C0E5A0", VA = "0x186C0F9A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F980", Offset = "0x6C0E580", VA = "0x186C0F980")]
		public static OverridableVector3 FGDKAMMLLCN(Vector3 JEODFFDGHHF)
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
