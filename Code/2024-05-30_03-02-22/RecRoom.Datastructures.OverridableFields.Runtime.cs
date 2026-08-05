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
public interface LHFPGCIFGGC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KGFFHNCICIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object MBBGNKFAGOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EDNOKBOIKAM<T> : LHFPGCIFGGC
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T OGADOHBOMGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BJHJGJIBJLD<T> : EDNOKBOIKAM<T>, LHFPGCIFGGC
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool KGFFHNCICIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T OGADOHBOMGE
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
public interface DPALFIKLNPA<T> : BJHJGJIBJLD<T>, EDNOKBOIKAM<T>, LHFPGCIFGGC
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool ILLKAMJNLNM
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
	public struct OverridableInt : EDNOKBOIKAM<int>, LHFPGCIFGGC
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
			[Cpp2IlInjected.Address(RVA = "0x1C8DA40", Offset = "0x1C8CC40", VA = "0x181C8DA40", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x63CD820", Offset = "0x63CCA20", VA = "0x1863CD820", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x24131E0", Offset = "0x24123E0", VA = "0x1824131E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x63CD780", Offset = "0x63CC980", VA = "0x1863CD780", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : EDNOKBOIKAM<string>, LHFPGCIFGGC
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
			[Cpp2IlInjected.Address(RVA = "0x1C8DA40", Offset = "0x1C8CC40", VA = "0x181C8DA40", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x837D60", Offset = "0x836F60", VA = "0x180837D60", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x837D60", Offset = "0x836F60", VA = "0x180837D60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x63CD870", Offset = "0x63CCA70", VA = "0x1863CD870", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : BJHJGJIBJLD<InnerType>, EDNOKBOIKAM<InnerType>, LHFPGCIFGGC where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool KGFFHNCICIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType OGADOHBOMGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object MBBGNKFAGOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2053E20", Offset = "0x2053020", VA = "0x182053E20", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x418C8D0", Offset = "0x418BAD0", VA = "0x18418C8D0")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x418C900", Offset = "0x418BB00", VA = "0x18418C900")]
		public MutableOverridableBase(bool AHJICHALJLL, [NotNull] InnerType HLCKBKFCMPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x418C130", Offset = "0x418B330", VA = "0x18418C130", Slot = "15")]
		public void DPGIBPJNCPJ(EDNOKBOIKAM<InnerType> OINJHLFKAEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x418C6D0", Offset = "0x418B8D0", VA = "0x18418C6D0", Slot = "16")]
		public void NJPJPNDOPCO(EDNOKBOIKAM<InnerType> JPLJHFMPDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x418BF00", Offset = "0x418B100", VA = "0x18418BF00", Slot = "17")]
		public virtual void CFPPHLPBNAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType LIIIBECPAMO();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void PNLDMGNNLBO(ProtobufType NFNBJHHEHJF);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void CBLKEALPNIL(byte[] FOFGDBMAIBN);
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
			[Cpp2IlInjected.Address(RVA = "0x8CC9A0", Offset = "0x8CBBA0", VA = "0x1808CC9A0", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x906310", Offset = "0x905510", VA = "0x180906310", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1B74050", Offset = "0x1B73250", VA = "0x181B74050", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x39A3A60", Offset = "0x39A2C60", VA = "0x1839A3A60")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3A3ECA0", Offset = "0x3A3DEA0", VA = "0x183A3ECA0")]
		public SerializedMutableOverridableBase(bool AHJICHALJLL, InnerType HLCKBKFCMPI)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, DIJBHCDJIMC>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x63CD6B0", Offset = "0x63CC8B0", VA = "0x1863CD6B0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x63CD710", Offset = "0x63CC910", VA = "0x1863CD710")]
		public MutableOverridableObscuredInt(bool AHJICHALJLL, ObscuredInt HLCKBKFCMPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x63CD5E0", Offset = "0x63CC7E0", VA = "0x1863CD5E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x63CD370", Offset = "0x63CC570", VA = "0x1863CD370", Slot = "20")]
		public override void CBLKEALPNIL(byte[] FOFGDBMAIBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x63CD530", Offset = "0x63CC730", VA = "0x1863CD530", Slot = "19")]
		public override void PNLDMGNNLBO(DIJBHCDJIMC NFNBJHHEHJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x63CD450", Offset = "0x63CC650", VA = "0x1863CD450", Slot = "18")]
		public override DIJBHCDJIMC LIIIBECPAMO()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, AKBEOPJPLDO>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x63CD2A0", Offset = "0x63CC4A0", VA = "0x1863CD2A0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x63CD300", Offset = "0x63CC500", VA = "0x1863CD300")]
		public MutableOverridableObscuredFloat(bool AHJICHALJLL, ObscuredFloat HLCKBKFCMPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x63CD1D0", Offset = "0x63CC3D0", VA = "0x1863CD1D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x63CCF40", Offset = "0x63CC140", VA = "0x1863CCF40", Slot = "20")]
		public override void CBLKEALPNIL(byte[] FOFGDBMAIBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x63CD110", Offset = "0x63CC310", VA = "0x1863CD110", Slot = "19")]
		public override void PNLDMGNNLBO(AKBEOPJPLDO NFNBJHHEHJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x63CD020", Offset = "0x63CC220", VA = "0x1863CD020", Slot = "18")]
		public override AKBEOPJPLDO LIIIBECPAMO()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, MLDLOADPDEP>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x63CC160", Offset = "0x63CB360", VA = "0x1863CC160")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x63CCED0", Offset = "0x63CC0D0", VA = "0x1863CCED0")]
		public MutableOverridableObscuredBool(bool AHJICHALJLL, ObscuredBool HLCKBKFCMPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x63CCE00", Offset = "0x63CC000", VA = "0x1863CCE00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x63CCAE0", Offset = "0x63CBCE0", VA = "0x1863CCAE0", Slot = "20")]
		public override void CBLKEALPNIL(byte[] FOFGDBMAIBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x63CCD40", Offset = "0x63CBF40", VA = "0x1863CCD40", Slot = "19")]
		public override void PNLDMGNNLBO(MLDLOADPDEP NFNBJHHEHJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x63CCBC0", Offset = "0x63CBDC0", VA = "0x1863CCBC0", Slot = "18")]
		public override MLDLOADPDEP LIIIBECPAMO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x63CCCB0", Offset = "0x63CBEB0", VA = "0x1863CCCB0", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, DPALFIKLNPA<ObscuredBool>, BJHJGJIBJLD<ObscuredBool>, EDNOKBOIKAM<ObscuredBool>, LHFPGCIFGGC
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7CEA50", Offset = "0x7CDC50", VA = "0x1807CEA50", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7CE8B0", Offset = "0x7CDAB0", VA = "0x1807CE8B0", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x63CC160", Offset = "0x63CB360", VA = "0x1863CC160")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x63CC0E0", Offset = "0x63CB2E0", VA = "0x1863CC0E0")]
		public void DPGIBPJNCPJ(MutableOverridableDefaultableObscuredBool JPLJHFMPDFD)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, DIJBHCDJIMC> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x45AD7E0", Offset = "0x45AC9E0", VA = "0x1845AD7E0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x45AD8F0", Offset = "0x45ACAF0", VA = "0x1845AD8F0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x39E8A80", Offset = "0x39E7C80", VA = "0x1839E8A80")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x45AD7C0", Offset = "0x45AC9C0", VA = "0x1845AD7C0")]
		public SerializedMutableOverridableObscuredEnum(bool AHJICHALJLL, TObsEnum HLCKBKFCMPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x45AD5D0", Offset = "0x45AC7D0", VA = "0x1845AD5D0", Slot = "18")]
		public sealed override DIJBHCDJIMC LIIIBECPAMO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x45AD6C0", Offset = "0x45AC8C0", VA = "0x1845AD6C0", Slot = "19")]
		public sealed override void PNLDMGNNLBO(DIJBHCDJIMC NFNBJHHEHJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x45AD480", Offset = "0x45AC680", VA = "0x1845AD480", Slot = "20")]
		public sealed override void CBLKEALPNIL(byte[] FOFGDBMAIBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x45AD560", Offset = "0x45AC760", VA = "0x1845AD560", Slot = "17")]
		public sealed override void CFPPHLPBNAM()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, EMACGNKPDAK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x63CCA10", Offset = "0x63CBC10", VA = "0x1863CCA10", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x63CCA50", Offset = "0x63CBC50", VA = "0x1863CCA50", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x63CC970", Offset = "0x63CBB70", VA = "0x1863CC970")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x63CC910", Offset = "0x63CBB10", VA = "0x1863CC910")]
		public MutableOverridableListObscuredString(bool AHJICHALJLL, List<ObscuredString> HLCKBKFCMPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x63CC870", Offset = "0x63CBA70", VA = "0x1863CC870", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x63CC2B0", Offset = "0x63CB4B0", VA = "0x1863CC2B0", Slot = "17")]
		public override void CFPPHLPBNAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x63CC1D0", Offset = "0x63CB3D0", VA = "0x1863CC1D0", Slot = "20")]
		public override void CBLKEALPNIL(byte[] FOFGDBMAIBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x63CC520", Offset = "0x63CB720", VA = "0x1863CC520", Slot = "19")]
		public override void PNLDMGNNLBO(EMACGNKPDAK NFNBJHHEHJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x63CC340", Offset = "0x63CB540", VA = "0x1863CC340", Slot = "18")]
		public override EMACGNKPDAK LIIIBECPAMO()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : EDNOKBOIKAM<Vector3>, LHFPGCIFGGC
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
			[Cpp2IlInjected.Address(RVA = "0x1C8DA40", Offset = "0x1C8CC40", VA = "0x181C8DA40", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x63CD9A0", Offset = "0x63CCBA0", VA = "0x1863CD9A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x3F24A40", Offset = "0x3F23C40", VA = "0x183F24A40", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x426A7B0", Offset = "0x42699B0", VA = "0x18426A7B0")]
		public OverridableVector3(Vector3 HLCKBKFCMPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x47E9BB0", Offset = "0x47E8DB0", VA = "0x1847E9BB0")]
		public OverridableVector3(bool AHJICHALJLL, Vector3 HLCKBKFCMPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x63CD900", Offset = "0x63CCB00", VA = "0x1863CD900", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x63CD8E0", Offset = "0x63CCAE0", VA = "0x1863CD8E0")]
		public static OverridableVector3 LOFAPGLBJHK(Vector3 LGIDDHPGAND)
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
