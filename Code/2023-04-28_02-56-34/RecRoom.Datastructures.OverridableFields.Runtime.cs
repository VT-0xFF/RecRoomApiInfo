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
public interface FIGOCOFCOBP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool AFNFEBHHMDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object CFJKADLIFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DCGPCEHKFDH<T> : FIGOCOFCOBP
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T NDNOLKCBONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LGMFKOANLOF<T> : global::DCGPCEHKFDH<T>, FIGOCOFCOBP
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool AFNFEBHHMDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T NDNOLKCBONM
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
public interface FMAAGMJGCEP<T> : global::LGMFKOANLOF<T>, global::DCGPCEHKFDH<T>, FIGOCOFCOBP
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool NKEHDCHKABP
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
	public struct OverridableInt : global::DCGPCEHKFDH<int>, FIGOCOFCOBP
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
			[Cpp2IlInjected.Address(RVA = "0x8CE490", Offset = "0x8CCE90", VA = "0x1808CE490", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x69F43B0", Offset = "0x69F2DB0", VA = "0x1869F43B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8C40C0", Offset = "0x8C2AC0", VA = "0x1808C40C0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x69F4310", Offset = "0x69F2D10", VA = "0x1869F4310", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : global::DCGPCEHKFDH<string>, FIGOCOFCOBP
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
			[Cpp2IlInjected.Address(RVA = "0x8CE490", Offset = "0x8CCE90", VA = "0x1808CE490", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x767330", Offset = "0x765D30", VA = "0x180767330", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x767330", Offset = "0x765D30", VA = "0x180767330", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x69F4400", Offset = "0x69F2E00", VA = "0x1869F4400", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : global::LGMFKOANLOF<InnerType>, global::DCGPCEHKFDH<InnerType>, FIGOCOFCOBP where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool AFNFEBHHMDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType NDNOLKCBONM
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object CFJKADLIFMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2358590", Offset = "0x2356F90", VA = "0x182358590", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2358300", Offset = "0x2356D00", VA = "0x182358300")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x23583C0", Offset = "0x2356DC0", VA = "0x1823583C0")]
		public MutableOverridableBase(bool NCKOBMCKFDE, [NotNull] InnerType LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2358130", Offset = "0x2356B30", VA = "0x182358130", Slot = "15")]
		public void MNLIHOGNBPH(global::DCGPCEHKFDH<InnerType> KPDKPCHGMJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2357DA0", Offset = "0x23567A0", VA = "0x182357DA0", Slot = "16")]
		public void MLOEOOCDIIH(global::DCGPCEHKFDH<InnerType> MPHACEGLFIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x23578C0", Offset = "0x23562C0", VA = "0x1823578C0", Slot = "17")]
		public virtual void JAIKDMLJCNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType AHMGOBHNBEG();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void HDFOBCICHPI(ProtobufType GELIMIHGABP);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void AJJFMACIMCM(byte[] BDCJONFOPDP);
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
			[Cpp2IlInjected.Address(RVA = "0x754640", Offset = "0x753040", VA = "0x180754640", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7B6C20", Offset = "0x7B5620", VA = "0x1807B6C20", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x174BA30", Offset = "0x174A430", VA = "0x18174BA30", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1375A20", Offset = "0x1374420", VA = "0x181375A20")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x29D9BB0", Offset = "0x29D85B0", VA = "0x1829D9BB0")]
		public SerializedMutableOverridableBase(bool NCKOBMCKFDE, InnerType LPJDDLMPNCG)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, OCCDJCLABNK>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x69F42B0", Offset = "0x69F2CB0", VA = "0x1869F42B0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x69F4240", Offset = "0x69F2C40", VA = "0x1869F4240")]
		public MutableOverridableObscuredInt(bool NCKOBMCKFDE, ObscuredInt LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x69F4170", Offset = "0x69F2B70", VA = "0x1869F4170", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x69F3FB0", Offset = "0x69F29B0", VA = "0x1869F3FB0", Slot = "20")]
		public override void AJJFMACIMCM(byte[] BDCJONFOPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x69F40B0", Offset = "0x69F2AB0", VA = "0x1869F40B0", Slot = "19")]
		public override void HDFOBCICHPI(OCCDJCLABNK GELIMIHGABP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x69F3ED0", Offset = "0x69F28D0", VA = "0x1869F3ED0", Slot = "18")]
		public override OCCDJCLABNK AHMGOBHNBEG()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, HDKKODBDPHP>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x69F3E00", Offset = "0x69F2800", VA = "0x1869F3E00")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x69F3E60", Offset = "0x69F2860", VA = "0x1869F3E60")]
		public MutableOverridableObscuredFloat(bool NCKOBMCKFDE, ObscuredFloat LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x69F3D30", Offset = "0x69F2730", VA = "0x1869F3D30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x69F3B60", Offset = "0x69F2560", VA = "0x1869F3B60", Slot = "20")]
		public override void AJJFMACIMCM(byte[] BDCJONFOPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x69F3C60", Offset = "0x69F2660", VA = "0x1869F3C60", Slot = "19")]
		public override void HDFOBCICHPI(HDKKODBDPHP GELIMIHGABP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x69F3A70", Offset = "0x69F2470", VA = "0x1869F3A70", Slot = "18")]
		public override HDKKODBDPHP AHMGOBHNBEG()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, HDOKKMJKLLA>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x69F2D30", Offset = "0x69F1730", VA = "0x1869F2D30")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x69F3A00", Offset = "0x69F2400", VA = "0x1869F3A00")]
		public MutableOverridableObscuredBool(bool NCKOBMCKFDE, ObscuredBool LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x69F3930", Offset = "0x69F2330", VA = "0x1869F3930", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x69F3730", Offset = "0x69F2130", VA = "0x1869F3730", Slot = "20")]
		public override void AJJFMACIMCM(byte[] BDCJONFOPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x69F3830", Offset = "0x69F2230", VA = "0x1869F3830", Slot = "19")]
		public override void HDFOBCICHPI(HDOKKMJKLLA GELIMIHGABP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x69F3650", Offset = "0x69F2050", VA = "0x1869F3650", Slot = "18")]
		public override HDOKKMJKLLA AHMGOBHNBEG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x69F38F0", Offset = "0x69F22F0", VA = "0x1869F38F0", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, global::FMAAGMJGCEP<ObscuredBool>, global::LGMFKOANLOF<ObscuredBool>, global::DCGPCEHKFDH<ObscuredBool>, FIGOCOFCOBP
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x72BD70", Offset = "0x72A770", VA = "0x18072BD70", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x936740", Offset = "0x935140", VA = "0x180936740", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x69F2D30", Offset = "0x69F1730", VA = "0x1869F2D30")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x69F2CB0", Offset = "0x69F16B0", VA = "0x1869F2CB0")]
		public void MNLIHOGNBPH(MutableOverridableDefaultableObscuredBool MPHACEGLFIL)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, OCCDJCLABNK> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x3659540", Offset = "0x3657F40", VA = "0x183659540", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x3659620", Offset = "0x3658020", VA = "0x183659620", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2318E70", Offset = "0x2317870", VA = "0x182318E70")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3659510", Offset = "0x3657F10", VA = "0x183659510")]
		public SerializedMutableOverridableObscuredEnum(TObsEnum LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x33A04A0", Offset = "0x339EEA0", VA = "0x1833A04A0")]
		public SerializedMutableOverridableObscuredEnum(bool NCKOBMCKFDE, TObsEnum LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x36591F0", Offset = "0x3657BF0", VA = "0x1836591F0", Slot = "18")]
		public sealed override OCCDJCLABNK AHMGOBHNBEG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x36593A0", Offset = "0x3657DA0", VA = "0x1836593A0", Slot = "19")]
		public sealed override void HDFOBCICHPI(OCCDJCLABNK GELIMIHGABP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x36592A0", Offset = "0x3657CA0", VA = "0x1836592A0", Slot = "20")]
		public sealed override void AJJFMACIMCM(byte[] BDCJONFOPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x36594B0", Offset = "0x3657EB0", VA = "0x1836594B0", Slot = "17")]
		public sealed override void JAIKDMLJCNA()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, BGAKMLFJOKG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x69F3580", Offset = "0x69F1F80", VA = "0x1869F3580", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x69F35C0", Offset = "0x69F1FC0", VA = "0x1869F35C0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x69F3490", Offset = "0x69F1E90", VA = "0x1869F3490")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x69F3520", Offset = "0x69F1F20", VA = "0x1869F3520")]
		public MutableOverridableListObscuredString(bool NCKOBMCKFDE, List<ObscuredString> LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x69F33F0", Offset = "0x69F1DF0", VA = "0x1869F33F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x69F3380", Offset = "0x69F1D80", VA = "0x1869F3380", Slot = "17")]
		public override void JAIKDMLJCNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x69F2F60", Offset = "0x69F1960", VA = "0x1869F2F60", Slot = "20")]
		public override void AJJFMACIMCM(byte[] BDCJONFOPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x69F3060", Offset = "0x69F1A60", VA = "0x1869F3060", Slot = "19")]
		public override void HDFOBCICHPI(BGAKMLFJOKG GELIMIHGABP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x69F2DA0", Offset = "0x69F17A0", VA = "0x1869F2DA0", Slot = "18")]
		public override BGAKMLFJOKG AHMGOBHNBEG()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : global::DCGPCEHKFDH<Vector3>, FIGOCOFCOBP
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
			[Cpp2IlInjected.Address(RVA = "0x8CE490", Offset = "0x8CCE90", VA = "0x1808CE490", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x69F4550", Offset = "0x69F2F50", VA = "0x1869F4550", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x2352250", Offset = "0x2350C50", VA = "0x182352250", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x69F4530", Offset = "0x69F2F30", VA = "0x1869F4530")]
		public OverridableVector3(Vector3 LPJDDLMPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x69F4490", Offset = "0x69F2E90", VA = "0x1869F4490", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x69F4470", Offset = "0x69F2E70", VA = "0x1869F4470")]
		public static OverridableVector3 HPHCHABBDNG(Vector3 IHADMCKJLJA)
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
