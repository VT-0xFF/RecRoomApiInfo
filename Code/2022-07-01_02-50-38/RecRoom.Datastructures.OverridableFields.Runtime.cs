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
public interface PMJGKLPKDFD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KAEOMIONEKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object PINBFADDAFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DDJAMFKCKCO<T> : PMJGKLPKDFD
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T MKOCEBDLMLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface NMJHFLEAGNG<T> : global::DDJAMFKCKCO<T>, PMJGKLPKDFD
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool KAEOMIONEKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T MKOCEBDLMLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
namespace RecRoom.Utils.OverridableFields
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct OverridableInt : global::DDJAMFKCKCO<int>, PMJGKLPKDFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private int value;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x821FF0", Offset = "0x8207F0", VA = "0x180821FF0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x122F060", Offset = "0x122D860", VA = "0x18122F060", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9C1C50", Offset = "0x9C0450", VA = "0x1809C1C50", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x122EFE0", Offset = "0x122D7E0", VA = "0x18122EFE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct OverridableString : global::DDJAMFKCKCO<string>, PMJGKLPKDFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private string value;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x821FF0", Offset = "0x8207F0", VA = "0x180821FF0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x719050", Offset = "0x717850", VA = "0x180719050", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x719050", Offset = "0x717850", VA = "0x180719050", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x122F0B0", Offset = "0x122D8B0", VA = "0x18122F0B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : global::NMJHFLEAGNG<InnerType>, global::DDJAMFKCKCO<InnerType>, PMJGKLPKDFD where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public abstract bool KAEOMIONEKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract InnerType MKOCEBDLMLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public object PINBFADDAFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2D72F60", Offset = "0x2D71760", VA = "0x182D72F60", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2D72D40", Offset = "0x2D71540", VA = "0x182D72D40")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2D72DF0", Offset = "0x2D715F0", VA = "0x182D72DF0")]
		public MutableOverridableBase(bool MNGFMDEDGIG, [NotNull] InnerType HKJMLEKHILN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2D72A60", Offset = "0x2D71260", VA = "0x182D72A60", Slot = "15")]
		public void LBAAIEIAOAA(global::DDJAMFKCKCO<InnerType> DLDOBAPPBNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2D72210", Offset = "0x2D70A10", VA = "0x182D72210", Slot = "16")]
		public void AJJNBKNAAAA(global::DDJAMFKCKCO<InnerType> EFDJFLPIKFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2D72B30", Offset = "0x2D71330", VA = "0x182D72B30", Slot = "17")]
		public virtual void OFNBBDALODO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType HBMBNAGDCHK();

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void JFGJENHMOJJ(ProtobufType LDNCIEBMBCJ);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void FCKLBMLKDMN(byte[] MMELDKALKAJ);
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
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

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x577160", Offset = "0x575960", VA = "0x180577160", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5DDA50", Offset = "0x5DC250", VA = "0x1805DDA50", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x164DB00", Offset = "0x164C300", VA = "0x18164DB00", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x217F720", Offset = "0x217DF20", VA = "0x18217F720")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2D7C380", Offset = "0x2D7AB80", VA = "0x182D7C380")]
		public SerializedMutableOverridableBase(bool MNGFMDEDGIG, InnerType HKJMLEKHILN)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, NGPJBALDLHK> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x2D7C7D0", Offset = "0x2D7AFD0", VA = "0x182D7C7D0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2D7C8B0", Offset = "0x2D7B0B0", VA = "0x182D7C8B0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x23CFA30", Offset = "0x23CE230", VA = "0x1823CFA30")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2D7C7A0", Offset = "0x2D7AFA0", VA = "0x182D7C7A0")]
		public SerializedMutableOverridableObscuredEnum(TObsEnum HKJMLEKHILN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2D7C770", Offset = "0x2D7AF70", VA = "0x182D7C770")]
		public SerializedMutableOverridableObscuredEnum(bool MNGFMDEDGIG, TObsEnum HKJMLEKHILN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2D7C540", Offset = "0x2D7AD40", VA = "0x182D7C540", Slot = "18")]
		public sealed override NGPJBALDLHK HBMBNAGDCHK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2D7C600", Offset = "0x2D7AE00", VA = "0x182D7C600", Slot = "19")]
		public sealed override void JFGJENHMOJJ(NGPJBALDLHK LDNCIEBMBCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2D7C450", Offset = "0x2D7AC50", VA = "0x182D7C450", Slot = "20")]
		public sealed override void FCKLBMLKDMN(byte[] MMELDKALKAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2D7C710", Offset = "0x2D7AF10", VA = "0x182D7C710", Slot = "17")]
		public sealed override void OFNBBDALODO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, NGPJBALDLHK>
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x122EF70", Offset = "0x122D770", VA = "0x18122EF70")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x122EF00", Offset = "0x122D700", VA = "0x18122EF00")]
		public MutableOverridableObscuredInt(bool MNGFMDEDGIG, ObscuredInt HKJMLEKHILN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x122EE50", Offset = "0x122D650", VA = "0x18122EE50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x122EBD0", Offset = "0x122D3D0", VA = "0x18122EBD0", Slot = "20")]
		public override void FCKLBMLKDMN(byte[] MMELDKALKAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x122ED90", Offset = "0x122D590", VA = "0x18122ED90", Slot = "19")]
		public override void JFGJENHMOJJ(NGPJBALDLHK LDNCIEBMBCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x122ECC0", Offset = "0x122D4C0", VA = "0x18122ECC0", Slot = "18")]
		public override NGPJBALDLHK HBMBNAGDCHK()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, NPACPHHBNEP>
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x122EAF0", Offset = "0x122D2F0", VA = "0x18122EAF0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x122EB60", Offset = "0x122D360", VA = "0x18122EB60")]
		public MutableOverridableObscuredFloat(bool MNGFMDEDGIG, ObscuredFloat HKJMLEKHILN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x122EA40", Offset = "0x122D240", VA = "0x18122EA40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x122E7A0", Offset = "0x122CFA0", VA = "0x18122E7A0", Slot = "20")]
		public override void FCKLBMLKDMN(byte[] MMELDKALKAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x122E970", Offset = "0x122D170", VA = "0x18122E970", Slot = "19")]
		public override void JFGJENHMOJJ(NPACPHHBNEP LDNCIEBMBCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x122E890", Offset = "0x122D090", VA = "0x18122E890", Slot = "18")]
		public override NPACPHHBNEP HBMBNAGDCHK()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, LLFLIKHNPNF>
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x122E6D0", Offset = "0x122CED0", VA = "0x18122E6D0")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x122E730", Offset = "0x122CF30", VA = "0x18122E730")]
		public MutableOverridableObscuredBool(bool MNGFMDEDGIG, ObscuredBool HKJMLEKHILN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x122E620", Offset = "0x122CE20", VA = "0x18122E620", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x122E390", Offset = "0x122CB90", VA = "0x18122E390", Slot = "20")]
		public override void FCKLBMLKDMN(byte[] MMELDKALKAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x122E560", Offset = "0x122CD60", VA = "0x18122E560", Slot = "19")]
		public override void JFGJENHMOJJ(LLFLIKHNPNF LDNCIEBMBCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x122E480", Offset = "0x122CC80", VA = "0x18122E480", Slot = "18")]
		public override LLFLIKHNPNF HBMBNAGDCHK()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, DGHMKPPKJDA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x122E2E0", Offset = "0x122CAE0", VA = "0x18122E2E0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x122E320", Offset = "0x122CB20", VA = "0x18122E320", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x122E260", Offset = "0x122CA60", VA = "0x18122E260")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x122E200", Offset = "0x122CA00", VA = "0x18122E200")]
		public MutableOverridableListObscuredString(bool MNGFMDEDGIG, List<ObscuredString> HKJMLEKHILN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x122E170", Offset = "0x122C970", VA = "0x18122E170", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x122E100", Offset = "0x122C900", VA = "0x18122E100", Slot = "17")]
		public override void OFNBBDALODO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x122DB60", Offset = "0x122C360", VA = "0x18122DB60", Slot = "20")]
		public override void FCKLBMLKDMN(byte[] MMELDKALKAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x122DE00", Offset = "0x122C600", VA = "0x18122DE00", Slot = "19")]
		public override void JFGJENHMOJJ(DGHMKPPKJDA LDNCIEBMBCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x122DC50", Offset = "0x122C450", VA = "0x18122DC50", Slot = "18")]
		public override DGHMKPPKJDA HBMBNAGDCHK()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct OverridableVector3 : global::DDJAMFKCKCO<Vector3>, PMJGKLPKDFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private Vector3 value;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x821FF0", Offset = "0x8207F0", VA = "0x180821FF0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x122F1E0", Offset = "0x122D9E0", VA = "0x18122F1E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x122F230", Offset = "0x122DA30", VA = "0x18122F230", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x122F1C0", Offset = "0x122D9C0", VA = "0x18122F1C0")]
		public OverridableVector3(Vector3 HKJMLEKHILN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x122F130", Offset = "0x122D930", VA = "0x18122F130", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x122F110", Offset = "0x122D910", VA = "0x18122F110")]
		public static OverridableVector3 EMMCEJFBHBP(Vector3 FMHKLFGOBKK)
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
