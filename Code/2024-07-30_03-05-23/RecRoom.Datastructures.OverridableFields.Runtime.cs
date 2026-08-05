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
public interface NBALBJOEGEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FLKPHDPFLNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object JPEEOOILBHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KGEMAIHFCJB<T> : NBALBJOEGEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T FJLALGMPANI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LBHCCFECNKH<T> : KGEMAIHFCJB<T>, NBALBJOEGEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool FLKPHDPFLNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T FJLALGMPANI
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
public interface HBHOHMJFCPE<T> : LBHCCFECNKH<T>, KGEMAIHFCJB<T>, NBALBJOEGEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool LAFDFAJAFKC
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
	public struct OverridableInt : KGEMAIHFCJB<int>, NBALBJOEGEJ
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
			[Cpp2IlInjected.Address(RVA = "0x1DD0B70", Offset = "0x1DCF170", VA = "0x181DD0B70", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x69D5C40", Offset = "0x69D4240", VA = "0x1869D5C40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x259FD50", Offset = "0x259E350", VA = "0x18259FD50", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x69D5BA0", Offset = "0x69D41A0", VA = "0x1869D5BA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : KGEMAIHFCJB<string>, NBALBJOEGEJ
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
			[Cpp2IlInjected.Address(RVA = "0x1DD0B70", Offset = "0x1DCF170", VA = "0x181DD0B70", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8FA820", Offset = "0x8F8E20", VA = "0x1808FA820", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8FA820", Offset = "0x8F8E20", VA = "0x1808FA820", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x69D5C90", Offset = "0x69D4290", VA = "0x1869D5C90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : LBHCCFECNKH<InnerType>, KGEMAIHFCJB<InnerType>, NBALBJOEGEJ where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool FLKPHDPFLNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType FJLALGMPANI
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object JPEEOOILBHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x218F4F0", Offset = "0x218DAF0", VA = "0x18218F4F0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4538CF0", Offset = "0x45372F0", VA = "0x184538CF0")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4538D20", Offset = "0x4537320", VA = "0x184538D20")]
		public MutableOverridableBase(bool FADHMOCHILH, [NotNull] InnerType DMNGPNKHPKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4538990", Offset = "0x4536F90", VA = "0x184538990", Slot = "15")]
		public void PPGANAKKCAO(KGEMAIHFCJB<InnerType> DOBMFCDBEKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4538500", Offset = "0x4536B00", VA = "0x184538500", Slot = "16")]
		public void AGJCCCHJIOG(KGEMAIHFCJB<InnerType> BHFGHGMPKOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4538950", Offset = "0x4536F50", VA = "0x184538950", Slot = "17")]
		public virtual void LJOBMJGJKLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType IBLOCMNLMCE();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void CKJKIJOPAFN(ProtobufType KIMBJMEEDCP);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void NLEDCGCCCIO(byte[] PGOHLDMCOKP);
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
			[Cpp2IlInjected.Address(RVA = "0x8B83E0", Offset = "0x8B69E0", VA = "0x1808B83E0", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x9E7AA0", Offset = "0x9E60A0", VA = "0x1809E7AA0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1CB0900", Offset = "0x1CAEF00", VA = "0x181CB0900", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x385C2B0", Offset = "0x385A8B0", VA = "0x18385C2B0")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3D362B0", Offset = "0x3D348B0", VA = "0x183D362B0")]
		public SerializedMutableOverridableBase(bool FADHMOCHILH, InnerType DMNGPNKHPKF)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, BCDPAHOMOAF>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x69D5AD0", Offset = "0x69D40D0", VA = "0x1869D5AD0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x69D5B30", Offset = "0x69D4130", VA = "0x1869D5B30")]
		public MutableOverridableObscuredInt(bool FADHMOCHILH, ObscuredInt DMNGPNKHPKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x69D5A00", Offset = "0x69D4000", VA = "0x1869D5A00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x69D5920", Offset = "0x69D3F20", VA = "0x1869D5920", Slot = "20")]
		public override void NLEDCGCCCIO(byte[] PGOHLDMCOKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x69D5790", Offset = "0x69D3D90", VA = "0x1869D5790", Slot = "19")]
		public override void CKJKIJOPAFN(BCDPAHOMOAF KIMBJMEEDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x69D5840", Offset = "0x69D3E40", VA = "0x1869D5840", Slot = "18")]
		public override BCDPAHOMOAF IBLOCMNLMCE()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, GDPKJFKHEBA>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x69D56C0", Offset = "0x69D3CC0", VA = "0x1869D56C0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x69D5720", Offset = "0x69D3D20", VA = "0x1869D5720")]
		public MutableOverridableObscuredFloat(bool FADHMOCHILH, ObscuredFloat DMNGPNKHPKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x69D55F0", Offset = "0x69D3BF0", VA = "0x1869D55F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x69D5510", Offset = "0x69D3B10", VA = "0x1869D5510", Slot = "20")]
		public override void NLEDCGCCCIO(byte[] PGOHLDMCOKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x69D5360", Offset = "0x69D3960", VA = "0x1869D5360", Slot = "19")]
		public override void CKJKIJOPAFN(GDPKJFKHEBA KIMBJMEEDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x69D5420", Offset = "0x69D3A20", VA = "0x1869D5420", Slot = "18")]
		public override GDPKJFKHEBA IBLOCMNLMCE()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, MDMEICOBJLN>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x69D4560", Offset = "0x69D2B60", VA = "0x1869D4560")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x69D52F0", Offset = "0x69D38F0", VA = "0x1869D52F0")]
		public MutableOverridableObscuredBool(bool FADHMOCHILH, ObscuredBool DMNGPNKHPKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x69D5220", Offset = "0x69D3820", VA = "0x1869D5220", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x69D50B0", Offset = "0x69D36B0", VA = "0x1869D50B0", Slot = "20")]
		public override void NLEDCGCCCIO(byte[] PGOHLDMCOKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x69D4F00", Offset = "0x69D3500", VA = "0x1869D4F00", Slot = "19")]
		public override void CKJKIJOPAFN(MDMEICOBJLN KIMBJMEEDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x69D4FC0", Offset = "0x69D35C0", VA = "0x1869D4FC0", Slot = "18")]
		public override MDMEICOBJLN IBLOCMNLMCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x69D5190", Offset = "0x69D3790", VA = "0x1869D5190", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, HBHOHMJFCPE<ObscuredBool>, LBHCCFECNKH<ObscuredBool>, KGEMAIHFCJB<ObscuredBool>, NBALBJOEGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x868CF0", Offset = "0x8672F0", VA = "0x180868CF0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x868CE0", Offset = "0x8672E0", VA = "0x180868CE0", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x69D4560", Offset = "0x69D2B60", VA = "0x1869D4560")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x69D44E0", Offset = "0x69D2AE0", VA = "0x1869D44E0")]
		public void PPGANAKKCAO(MutableOverridableDefaultableObscuredBool BHFGHGMPKOJ)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, BCDPAHOMOAF> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x49F3780", Offset = "0x49F1D80", VA = "0x1849F3780", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x49F3920", Offset = "0x49F1F20", VA = "0x1849F3920", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3DA26A0", Offset = "0x3DA0CA0", VA = "0x183DA26A0")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x49F3740", Offset = "0x49F1D40", VA = "0x1849F3740")]
		public SerializedMutableOverridableObscuredEnum(bool FADHMOCHILH, TObsEnum DMNGPNKHPKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x49F34F0", Offset = "0x49F1AF0", VA = "0x1849F34F0", Slot = "18")]
		public sealed override BCDPAHOMOAF IBLOCMNLMCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x49F33F0", Offset = "0x49F19F0", VA = "0x1849F33F0", Slot = "19")]
		public sealed override void CKJKIJOPAFN(BCDPAHOMOAF KIMBJMEEDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x49F3660", Offset = "0x49F1C60", VA = "0x1849F3660", Slot = "20")]
		public sealed override void NLEDCGCCCIO(byte[] PGOHLDMCOKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x49F35E0", Offset = "0x49F1BE0", VA = "0x1849F35E0", Slot = "17")]
		public sealed override void LJOBMJGJKLI()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, GIJONCHLNAF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x69D4E30", Offset = "0x69D3430", VA = "0x1869D4E30", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x69D4E70", Offset = "0x69D3470", VA = "0x1869D4E70", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x69D4D90", Offset = "0x69D3390", VA = "0x1869D4D90")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x69D4D30", Offset = "0x69D3330", VA = "0x1869D4D30")]
		public MutableOverridableListObscuredString(bool FADHMOCHILH, List<ObscuredString> DMNGPNKHPKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x69D4C90", Offset = "0x69D3290", VA = "0x1869D4C90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x69D4B20", Offset = "0x69D3120", VA = "0x1869D4B20", Slot = "17")]
		public override void LJOBMJGJKLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x69D4BB0", Offset = "0x69D31B0", VA = "0x1869D4BB0", Slot = "20")]
		public override void NLEDCGCCCIO(byte[] PGOHLDMCOKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x69D45D0", Offset = "0x69D2BD0", VA = "0x1869D45D0", Slot = "19")]
		public override void CKJKIJOPAFN(GIJONCHLNAF KIMBJMEEDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x69D4940", Offset = "0x69D2F40", VA = "0x1869D4940", Slot = "18")]
		public override GIJONCHLNAF IBLOCMNLMCE()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : KGEMAIHFCJB<Vector3>, NBALBJOEGEJ
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
			[Cpp2IlInjected.Address(RVA = "0x1DD0B70", Offset = "0x1DCF170", VA = "0x181DD0B70", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x69D5DC0", Offset = "0x69D43C0", VA = "0x1869D5DC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x42B0800", Offset = "0x42AEE00", VA = "0x1842B0800", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x468F3C0", Offset = "0x468D9C0", VA = "0x18468F3C0")]
		public OverridableVector3(Vector3 DMNGPNKHPKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4C828D0", Offset = "0x4C80ED0", VA = "0x184C828D0")]
		public OverridableVector3(bool FADHMOCHILH, Vector3 DMNGPNKHPKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x69D5D20", Offset = "0x69D4320", VA = "0x1869D5D20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x69D5D00", Offset = "0x69D4300", VA = "0x1869D5D00")]
		public static OverridableVector3 HDKGBCFDEBL(Vector3 KPJDKHEOHPO)
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
