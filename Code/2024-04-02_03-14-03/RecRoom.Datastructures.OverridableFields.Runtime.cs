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
public interface KBJCNGCHNAH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EOHOLHBHKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object ICFNGKOIEJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PNBIMMADNJE<T> : KBJCNGCHNAH
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T BLAEOCKJGCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface PPCMBMGIAPI<T> : PNBIMMADNJE<T>, KBJCNGCHNAH
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool EOHOLHBHKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T BLAEOCKJGCA
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
public interface POCNEGLALIC<T> : PPCMBMGIAPI<T>, PNBIMMADNJE<T>, KBJCNGCHNAH
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool JDGCAOMLCML
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
	public struct OverridableInt : PNBIMMADNJE<int>, KBJCNGCHNAH
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
			[Cpp2IlInjected.Address(RVA = "0x1B54620", Offset = "0x1B53220", VA = "0x181B54620", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x60F7FE0", Offset = "0x60F6BE0", VA = "0x1860F7FE0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x22BBEE0", Offset = "0x22BAAE0", VA = "0x1822BBEE0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x60F7F40", Offset = "0x60F6B40", VA = "0x1860F7F40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : PNBIMMADNJE<string>, KBJCNGCHNAH
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
			[Cpp2IlInjected.Address(RVA = "0x1B54620", Offset = "0x1B53220", VA = "0x181B54620", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9022F0", Offset = "0x900EF0", VA = "0x1809022F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9022F0", Offset = "0x900EF0", VA = "0x1809022F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x60F8030", Offset = "0x60F6C30", VA = "0x1860F8030", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : PPCMBMGIAPI<InnerType>, PNBIMMADNJE<InnerType>, KBJCNGCHNAH where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool EOHOLHBHKFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType BLAEOCKJGCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object ICFNGKOIEJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x1F64B00", Offset = "0x1F63700", VA = "0x181F64B00", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3EDC410", Offset = "0x3EDB010", VA = "0x183EDC410")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3EDC440", Offset = "0x3EDB040", VA = "0x183EDC440")]
		public MutableOverridableBase(bool JMOFFFJINOG, [NotNull] InnerType BLKAHBIJBJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3EDBD00", Offset = "0x3EDA900", VA = "0x183EDBD00", Slot = "15")]
		public void EAKEEGKMGFB(PNBIMMADNJE<InnerType> MHIFLJNAGOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3EDBFF0", Offset = "0x3EDABF0", VA = "0x183EDBFF0", Slot = "16")]
		public void PLJCLLNOGIK(PNBIMMADNJE<InnerType> NAFFCAIMPLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3EDBEF0", Offset = "0x3EDAAF0", VA = "0x183EDBEF0", Slot = "17")]
		public virtual void KEPEANOIAHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType GIHCBMJPLGI();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void JEIEFKNCAGJ(ProtobufType HKEAAGDLOCP);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void MADDPJBEFIJ(byte[] DOIMIBDBHAC);
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
			[Cpp2IlInjected.Address(RVA = "0x8029C0", Offset = "0x8015C0", VA = "0x1808029C0", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x869490", Offset = "0x868090", VA = "0x180869490", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1A5CDC0", Offset = "0x1A5B9C0", VA = "0x181A5CDC0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x388D1A0", Offset = "0x388BDA0", VA = "0x18388D1A0")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3C26810", Offset = "0x3C25410", VA = "0x183C26810")]
		public SerializedMutableOverridableBase(bool JMOFFFJINOG, InnerType BLKAHBIJBJO)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, BGAPCMLKNIK>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x60F7E70", Offset = "0x60F6A70", VA = "0x1860F7E70")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x60F7ED0", Offset = "0x60F6AD0", VA = "0x1860F7ED0")]
		public MutableOverridableObscuredInt(bool JMOFFFJINOG, ObscuredInt BLKAHBIJBJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x60F7DA0", Offset = "0x60F69A0", VA = "0x1860F7DA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x60F7CC0", Offset = "0x60F68C0", VA = "0x1860F7CC0", Slot = "20")]
		public override void MADDPJBEFIJ(byte[] DOIMIBDBHAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x60F7C10", Offset = "0x60F6810", VA = "0x1860F7C10", Slot = "19")]
		public override void JEIEFKNCAGJ(BGAPCMLKNIK HKEAAGDLOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x60F7B30", Offset = "0x60F6730", VA = "0x1860F7B30", Slot = "18")]
		public override BGAPCMLKNIK GIHCBMJPLGI()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, ODECLAFLJHM>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x60F7A60", Offset = "0x60F6660", VA = "0x1860F7A60")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x60F7AC0", Offset = "0x60F66C0", VA = "0x1860F7AC0")]
		public MutableOverridableObscuredFloat(bool JMOFFFJINOG, ObscuredFloat BLKAHBIJBJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x60F7990", Offset = "0x60F6590", VA = "0x1860F7990", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x60F78B0", Offset = "0x60F64B0", VA = "0x1860F78B0", Slot = "20")]
		public override void MADDPJBEFIJ(byte[] DOIMIBDBHAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x60F77F0", Offset = "0x60F63F0", VA = "0x1860F77F0", Slot = "19")]
		public override void JEIEFKNCAGJ(ODECLAFLJHM HKEAAGDLOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x60F7700", Offset = "0x60F6300", VA = "0x1860F7700", Slot = "18")]
		public override ODECLAFLJHM GIHCBMJPLGI()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, PNFDCLGEGPN>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x60F6910", Offset = "0x60F5510", VA = "0x1860F6910")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x60F7690", Offset = "0x60F6290", VA = "0x1860F7690")]
		public MutableOverridableObscuredBool(bool JMOFFFJINOG, ObscuredBool BLKAHBIJBJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x60F75C0", Offset = "0x60F61C0", VA = "0x1860F75C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x60F7450", Offset = "0x60F6050", VA = "0x1860F7450", Slot = "20")]
		public override void MADDPJBEFIJ(byte[] DOIMIBDBHAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x60F7390", Offset = "0x60F5F90", VA = "0x1860F7390", Slot = "19")]
		public override void JEIEFKNCAGJ(PNFDCLGEGPN HKEAAGDLOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x60F72A0", Offset = "0x60F5EA0", VA = "0x1860F72A0", Slot = "18")]
		public override PNFDCLGEGPN GIHCBMJPLGI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x60F7530", Offset = "0x60F6130", VA = "0x1860F7530", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, POCNEGLALIC<ObscuredBool>, PPCMBMGIAPI<ObscuredBool>, PNBIMMADNJE<ObscuredBool>, KBJCNGCHNAH
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7B9F80", Offset = "0x7B8B80", VA = "0x1807B9F80", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7B9E30", Offset = "0x7B8A30", VA = "0x1807B9E30", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x60F6910", Offset = "0x60F5510", VA = "0x1860F6910")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x60F6890", Offset = "0x60F5490", VA = "0x1860F6890")]
		public void EAKEEGKMGFB(MutableOverridableDefaultableObscuredBool NAFFCAIMPLI)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, BGAPCMLKNIK> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x42E6CE0", Offset = "0x42E58E0", VA = "0x1842E6CE0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x42E6E10", Offset = "0x42E5A10", VA = "0x1842E6E10", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x396CE80", Offset = "0x396BA80", VA = "0x18396CE80")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x42E6CC0", Offset = "0x42E58C0", VA = "0x1842E6CC0")]
		public SerializedMutableOverridableObscuredEnum(bool JMOFFFJINOG, TObsEnum BLKAHBIJBJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x42E6980", Offset = "0x42E5580", VA = "0x1842E6980", Slot = "18")]
		public sealed override BGAPCMLKNIK GIHCBMJPLGI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x42E6A70", Offset = "0x42E5670", VA = "0x1842E6A70", Slot = "19")]
		public sealed override void JEIEFKNCAGJ(BGAPCMLKNIK HKEAAGDLOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x42E6BE0", Offset = "0x42E57E0", VA = "0x1842E6BE0", Slot = "20")]
		public sealed override void MADDPJBEFIJ(byte[] DOIMIBDBHAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x42E6B70", Offset = "0x42E5770", VA = "0x1842E6B70", Slot = "17")]
		public sealed override void KEPEANOIAHO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, MELMEGGPKME>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x60F71D0", Offset = "0x60F5DD0", VA = "0x1860F71D0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x60F7210", Offset = "0x60F5E10", VA = "0x1860F7210", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x60F7130", Offset = "0x60F5D30", VA = "0x1860F7130")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x60F70D0", Offset = "0x60F5CD0", VA = "0x1860F70D0")]
		public MutableOverridableListObscuredString(bool JMOFFFJINOG, List<ObscuredString> BLKAHBIJBJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x60F7030", Offset = "0x60F5C30", VA = "0x1860F7030", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x60F6EC0", Offset = "0x60F5AC0", VA = "0x1860F6EC0", Slot = "17")]
		public override void KEPEANOIAHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x60F6F50", Offset = "0x60F5B50", VA = "0x1860F6F50", Slot = "20")]
		public override void MADDPJBEFIJ(byte[] DOIMIBDBHAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x60F6B60", Offset = "0x60F5760", VA = "0x1860F6B60", Slot = "19")]
		public override void JEIEFKNCAGJ(MELMEGGPKME HKEAAGDLOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x60F6980", Offset = "0x60F5580", VA = "0x1860F6980", Slot = "18")]
		public override MELMEGGPKME GIHCBMJPLGI()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : PNBIMMADNJE<Vector3>, KBJCNGCHNAH
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
			[Cpp2IlInjected.Address(RVA = "0x1B54620", Offset = "0x1B53220", VA = "0x181B54620", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x60F8160", Offset = "0x60F6D60", VA = "0x1860F8160", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x3BF6080", Offset = "0x3BF4C80", VA = "0x183BF6080", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3FE2C70", Offset = "0x3FE1870", VA = "0x183FE2C70")]
		public OverridableVector3(Vector3 BLKAHBIJBJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x60F80C0", Offset = "0x60F6CC0", VA = "0x1860F80C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x60F80A0", Offset = "0x60F6CA0", VA = "0x1860F80A0")]
		public static OverridableVector3 PFOIJBDHIHJ(Vector3 NOPNOIONIBO)
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
