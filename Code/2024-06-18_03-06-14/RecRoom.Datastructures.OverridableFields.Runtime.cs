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
public interface FOHFAJBNDLO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool OIBABCOOFOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object EGCCLBEMPAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BDKPHDNGODE<T> : FOHFAJBNDLO
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T NHLIMKDHAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LDLGMCALNFC<T> : BDKPHDNGODE<T>, FOHFAJBNDLO
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool OIBABCOOFOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T NHLIMKDHAIB
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
public interface AJDBMCMEJFJ<T> : LDLGMCALNFC<T>, BDKPHDNGODE<T>, FOHFAJBNDLO
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool GGGFGKNHGLD
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
	public struct OverridableInt : BDKPHDNGODE<int>, FOHFAJBNDLO
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
			[Cpp2IlInjected.Address(RVA = "0x1D5C580", Offset = "0x1D5AF80", VA = "0x181D5C580", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x689AC20", Offset = "0x6899620", VA = "0x18689AC20", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x253EE00", Offset = "0x253D800", VA = "0x18253EE00", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x689AB80", Offset = "0x6899580", VA = "0x18689AB80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : BDKPHDNGODE<string>, FOHFAJBNDLO
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
			[Cpp2IlInjected.Address(RVA = "0x1D5C580", Offset = "0x1D5AF80", VA = "0x181D5C580", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4B0", Offset = "0x8BDEB0", VA = "0x1808BF4B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4B0", Offset = "0x8BDEB0", VA = "0x1808BF4B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x689AC70", Offset = "0x6899670", VA = "0x18689AC70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : LDLGMCALNFC<InnerType>, BDKPHDNGODE<InnerType>, FOHFAJBNDLO where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool OIBABCOOFOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType NHLIMKDHAIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object EGCCLBEMPAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x212E510", Offset = "0x212CF10", VA = "0x18212E510", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x44C6B80", Offset = "0x44C5580", VA = "0x1844C6B80")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x44C6BB0", Offset = "0x44C55B0", VA = "0x1844C6BB0")]
		public MutableOverridableBase(bool LEGALBPGLBI, [NotNull] InnerType DBOBEHLEAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x44C6640", Offset = "0x44C5040", VA = "0x1844C6640", Slot = "15")]
		public void KFCKGHKHOPN(BDKPHDNGODE<InnerType> OFDLMEADNHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x44C6840", Offset = "0x44C5240", VA = "0x1844C6840", Slot = "16")]
		public void KHMOMCMPNHI(BDKPHDNGODE<InnerType> HENLEJBGFIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x44C6210", Offset = "0x44C4C10", VA = "0x1844C6210", Slot = "17")]
		public virtual void GLMNPCAHJLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType KPEKEDJBOJL();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void MAHDFACMAIN(ProtobufType HKNGOKFGMHB);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void PJPNPGCFDBL(byte[] ANBCODDLMEB);
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
			[Cpp2IlInjected.Address(RVA = "0x8A0E90", Offset = "0x89F890", VA = "0x1808A0E90", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x9A34A0", Offset = "0x9A1EA0", VA = "0x1809A34A0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1C3F790", Offset = "0x1C3E190", VA = "0x181C3F790", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3CF7AA0", Offset = "0x3CF64A0", VA = "0x183CF7AA0")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x447C840", Offset = "0x447B240", VA = "0x18447C840")]
		public SerializedMutableOverridableBase(bool LEGALBPGLBI, InnerType DBOBEHLEAAE)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, LHFDNPCFCIG>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x689AAB0", Offset = "0x68994B0", VA = "0x18689AAB0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x689AB10", Offset = "0x6899510", VA = "0x18689AB10")]
		public MutableOverridableObscuredInt(bool LEGALBPGLBI, ObscuredInt DBOBEHLEAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x689A9E0", Offset = "0x68993E0", VA = "0x18689A9E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x689A900", Offset = "0x6899300", VA = "0x18689A900", Slot = "20")]
		public override void PJPNPGCFDBL(byte[] ANBCODDLMEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x689A850", Offset = "0x6899250", VA = "0x18689A850", Slot = "19")]
		public override void MAHDFACMAIN(LHFDNPCFCIG HKNGOKFGMHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x689A770", Offset = "0x6899170", VA = "0x18689A770", Slot = "18")]
		public override LHFDNPCFCIG KPEKEDJBOJL()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, DFGOGCGGPIO>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x689A6A0", Offset = "0x68990A0", VA = "0x18689A6A0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x689A700", Offset = "0x6899100", VA = "0x18689A700")]
		public MutableOverridableObscuredFloat(bool LEGALBPGLBI, ObscuredFloat DBOBEHLEAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x689A5D0", Offset = "0x6898FD0", VA = "0x18689A5D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x689A4F0", Offset = "0x6898EF0", VA = "0x18689A4F0", Slot = "20")]
		public override void PJPNPGCFDBL(byte[] ANBCODDLMEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x689A430", Offset = "0x6898E30", VA = "0x18689A430", Slot = "19")]
		public override void MAHDFACMAIN(DFGOGCGGPIO HKNGOKFGMHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x689A340", Offset = "0x6898D40", VA = "0x18689A340", Slot = "18")]
		public override DFGOGCGGPIO KPEKEDJBOJL()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, NCKCBMNGCDL>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6899550", Offset = "0x6897F50", VA = "0x186899550")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x689A2D0", Offset = "0x6898CD0", VA = "0x18689A2D0")]
		public MutableOverridableObscuredBool(bool LEGALBPGLBI, ObscuredBool DBOBEHLEAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x689A200", Offset = "0x6898C00", VA = "0x18689A200", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x689A120", Offset = "0x6898B20", VA = "0x18689A120", Slot = "20")]
		public override void PJPNPGCFDBL(byte[] ANBCODDLMEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6899FD0", Offset = "0x68989D0", VA = "0x186899FD0", Slot = "19")]
		public override void MAHDFACMAIN(NCKCBMNGCDL HKNGOKFGMHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6899EE0", Offset = "0x68988E0", VA = "0x186899EE0", Slot = "18")]
		public override NCKCBMNGCDL KPEKEDJBOJL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x689A090", Offset = "0x6898A90", VA = "0x18689A090", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, AJDBMCMEJFJ<ObscuredBool>, LDLGMCALNFC<ObscuredBool>, BDKPHDNGODE<ObscuredBool>, FOHFAJBNDLO
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x84EC80", Offset = "0x84D680", VA = "0x18084EC80", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x84ECB0", Offset = "0x84D6B0", VA = "0x18084ECB0", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6899550", Offset = "0x6897F50", VA = "0x186899550")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x68994D0", Offset = "0x6897ED0", VA = "0x1868994D0")]
		public void KFCKGHKHOPN(MutableOverridableDefaultableObscuredBool HENLEJBGFIE)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, LHFDNPCFCIG> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x49210D0", Offset = "0x491FAD0", VA = "0x1849210D0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x4921250", Offset = "0x491FC50", VA = "0x184921250", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3DC5430", Offset = "0x3DC3E30", VA = "0x183DC5430")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4921090", Offset = "0x491FA90", VA = "0x184921090")]
		public SerializedMutableOverridableObscuredEnum(bool LEGALBPGLBI, TObsEnum DBOBEHLEAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4920DC0", Offset = "0x491F7C0", VA = "0x184920DC0", Slot = "18")]
		public sealed override LHFDNPCFCIG KPEKEDJBOJL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4920EB0", Offset = "0x491F8B0", VA = "0x184920EB0", Slot = "19")]
		public sealed override void MAHDFACMAIN(LHFDNPCFCIG HKNGOKFGMHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4920FB0", Offset = "0x491F9B0", VA = "0x184920FB0", Slot = "20")]
		public sealed override void PJPNPGCFDBL(byte[] ANBCODDLMEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4920D40", Offset = "0x491F740", VA = "0x184920D40", Slot = "17")]
		public sealed override void GLMNPCAHJLC()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, EGEEMBOAELP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6899E10", Offset = "0x6898810", VA = "0x186899E10", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6899E50", Offset = "0x6898850", VA = "0x186899E50", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6899D70", Offset = "0x6898770", VA = "0x186899D70")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6899D10", Offset = "0x6898710", VA = "0x186899D10")]
		public MutableOverridableListObscuredString(bool LEGALBPGLBI, List<ObscuredString> DBOBEHLEAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6899C70", Offset = "0x6898670", VA = "0x186899C70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x68995C0", Offset = "0x6897FC0", VA = "0x1868995C0", Slot = "17")]
		public override void GLMNPCAHJLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6899B90", Offset = "0x6898590", VA = "0x186899B90", Slot = "20")]
		public override void PJPNPGCFDBL(byte[] ANBCODDLMEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6899830", Offset = "0x6898230", VA = "0x186899830", Slot = "19")]
		public override void MAHDFACMAIN(EGEEMBOAELP HKNGOKFGMHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6899650", Offset = "0x6898050", VA = "0x186899650", Slot = "18")]
		public override EGEEMBOAELP KPEKEDJBOJL()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : BDKPHDNGODE<Vector3>, FOHFAJBNDLO
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
			[Cpp2IlInjected.Address(RVA = "0x1D5C580", Offset = "0x1D5AF80", VA = "0x181D5C580", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x689ADA0", Offset = "0x68997A0", VA = "0x18689ADA0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x4257420", Offset = "0x4255E20", VA = "0x184257420", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x45A7C00", Offset = "0x45A6600", VA = "0x1845A7C00")]
		public OverridableVector3(Vector3 DBOBEHLEAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4B97280", Offset = "0x4B95C80", VA = "0x184B97280")]
		public OverridableVector3(bool LEGALBPGLBI, Vector3 DBOBEHLEAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x689AD00", Offset = "0x6899700", VA = "0x18689AD00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x689ACE0", Offset = "0x68996E0", VA = "0x18689ACE0")]
		public static OverridableVector3 OCHPDIOAFKC(Vector3 EHIEOLDDJEB)
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
