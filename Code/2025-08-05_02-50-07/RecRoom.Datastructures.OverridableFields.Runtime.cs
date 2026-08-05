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
public interface HFHDOIIHAHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool IBOGHIDPACE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object KCNAFAHNMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FKCNHJENNHE<T> : HFHDOIIHAHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T JCMAOCOGHGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface IOJLKOFFMCG<T> : FKCNHJENNHE<T>, HFHDOIIHAHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool IBOGHIDPACE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T JCMAOCOGHGO
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
public interface IGCCBLEGFBO<T> : IOJLKOFFMCG<T>, FKCNHJENNHE<T>, HFHDOIIHAHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool HNJLLHHCPMF
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
	public struct OverridableInt : FKCNHJENNHE<int>, HFHDOIIHAHJ
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
			[Cpp2IlInjected.Address(RVA = "0x105C9D0", Offset = "0x105BDD0", VA = "0x18105C9D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x82692D0", Offset = "0x82686D0", VA = "0x1882692D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2FBBBB0", Offset = "0x2FBAFB0", VA = "0x182FBBBB0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8269230", Offset = "0x8268630", VA = "0x188269230", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : FKCNHJENNHE<string>, HFHDOIIHAHJ
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
			[Cpp2IlInjected.Address(RVA = "0x105C9D0", Offset = "0x105BDD0", VA = "0x18105C9D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xAF6930", Offset = "0xAF5D30", VA = "0x180AF6930", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAF6930", Offset = "0xAF5D30", VA = "0x180AF6930", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8269320", Offset = "0x8268720", VA = "0x188269320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : IOJLKOFFMCG<InnerType>, FKCNHJENNHE<InnerType>, HFHDOIIHAHJ where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool IBOGHIDPACE
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType JCMAOCOGHGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object KCNAFAHNMAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2CB4230", Offset = "0x2CB3630", VA = "0x182CB4230", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x57E1EE0", Offset = "0x57E12E0", VA = "0x1857E1EE0")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x57E1F10", Offset = "0x57E1310", VA = "0x1857E1F10")]
		public MutableOverridableBase(bool PLJOEFBBPNA, [NotNull] InnerType CBMEHPPMEEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x57E19A0", Offset = "0x57E0DA0", VA = "0x1857E19A0", Slot = "15")]
		public void MGEEINLCIAI(FKCNHJENNHE<InnerType> GEGOFMKNEED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x57E1CE0", Offset = "0x57E10E0", VA = "0x1857E1CE0", Slot = "16")]
		public void PKJKLOPGALM(FKCNHJENNHE<InnerType> LHDOHAKINKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x57E1510", Offset = "0x57E0910", VA = "0x1857E1510", Slot = "17")]
		public virtual void CNFJEHEIBKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType CEKOABLGEAG();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void KFKKEIEJHKF(ProtobufType LBMJEJIFGJN);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void OFPFHIBMMCN(byte[] MPPNOBEIAMJ);
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
			[Cpp2IlInjected.Address(RVA = "0xB32030", Offset = "0xB31430", VA = "0x180B32030", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xB32040", Offset = "0xB31440", VA = "0x180B32040", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xF39CC0", Offset = "0xF390C0", VA = "0x180F39CC0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x44ECB20", Offset = "0x44EBF20", VA = "0x1844ECB20")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4FE1790", Offset = "0x4FE0B90", VA = "0x184FE1790")]
		public SerializedMutableOverridableBase(bool PLJOEFBBPNA, InnerType CBMEHPPMEEA)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, BCBGLMJJCGI>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8269160", Offset = "0x8268560", VA = "0x188269160")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x82691C0", Offset = "0x82685C0", VA = "0x1882691C0")]
		public MutableOverridableObscuredInt(bool PLJOEFBBPNA, ObscuredInt CBMEHPPMEEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8269090", Offset = "0x8268490", VA = "0x188269090", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8268FB0", Offset = "0x82683B0", VA = "0x188268FB0", Slot = "20")]
		public override void OFPFHIBMMCN(byte[] MPPNOBEIAMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8268F00", Offset = "0x8268300", VA = "0x188268F00", Slot = "19")]
		public override void KFKKEIEJHKF(BCBGLMJJCGI LBMJEJIFGJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8268E20", Offset = "0x8268220", VA = "0x188268E20", Slot = "18")]
		public override BCBGLMJJCGI CEKOABLGEAG()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, BBMIFBCILDF>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8268D50", Offset = "0x8268150", VA = "0x188268D50")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8268DB0", Offset = "0x82681B0", VA = "0x188268DB0")]
		public MutableOverridableObscuredFloat(bool PLJOEFBBPNA, ObscuredFloat CBMEHPPMEEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8268C80", Offset = "0x8268080", VA = "0x188268C80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8268BA0", Offset = "0x8267FA0", VA = "0x188268BA0", Slot = "20")]
		public override void OFPFHIBMMCN(byte[] MPPNOBEIAMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8268AE0", Offset = "0x8267EE0", VA = "0x188268AE0", Slot = "19")]
		public override void KFKKEIEJHKF(BBMIFBCILDF LBMJEJIFGJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x82689F0", Offset = "0x8267DF0", VA = "0x1882689F0", Slot = "18")]
		public override BBMIFBCILDF CEKOABLGEAG()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, OBOOGJBKJCC>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8267C10", Offset = "0x8267010", VA = "0x188267C10")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8268980", Offset = "0x8267D80", VA = "0x188268980")]
		public MutableOverridableObscuredBool(bool PLJOEFBBPNA, ObscuredBool CBMEHPPMEEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x82688B0", Offset = "0x8267CB0", VA = "0x1882688B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8268740", Offset = "0x8267B40", VA = "0x188268740", Slot = "20")]
		public override void OFPFHIBMMCN(byte[] MPPNOBEIAMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8268680", Offset = "0x8267A80", VA = "0x188268680", Slot = "19")]
		public override void KFKKEIEJHKF(OBOOGJBKJCC LBMJEJIFGJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8268590", Offset = "0x8267990", VA = "0x188268590", Slot = "18")]
		public override OBOOGJBKJCC CEKOABLGEAG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8268820", Offset = "0x8267C20", VA = "0x188268820", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, IGCCBLEGFBO<ObscuredBool>, IOJLKOFFMCG<ObscuredBool>, FKCNHJENNHE<ObscuredBool>, HFHDOIIHAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA703B0", Offset = "0xA6F7B0", VA = "0x180A703B0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA702A0", Offset = "0xA6F6A0", VA = "0x180A702A0", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8267C10", Offset = "0x8267010", VA = "0x188267C10")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8267B90", Offset = "0x8266F90", VA = "0x188267B90")]
		public void MGEEINLCIAI(MutableOverridableDefaultableObscuredBool LHDOHAKINKP)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, BCBGLMJJCGI> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x5D421D0", Offset = "0x5D415D0", VA = "0x185D421D0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x5D422E0", Offset = "0x5D416E0", VA = "0x185D422E0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4F5B060", Offset = "0x4F5A460", VA = "0x184F5B060")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5D421B0", Offset = "0x5D415B0", VA = "0x185D421B0")]
		public SerializedMutableOverridableObscuredEnum(bool PLJOEFBBPNA, TObsEnum CBMEHPPMEEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5D41E70", Offset = "0x5D41270", VA = "0x185D41E70", Slot = "18")]
		public sealed override BCBGLMJJCGI CEKOABLGEAG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5D41FD0", Offset = "0x5D413D0", VA = "0x185D41FD0", Slot = "19")]
		public sealed override void KFKKEIEJHKF(BCBGLMJJCGI LBMJEJIFGJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5D420D0", Offset = "0x5D414D0", VA = "0x185D420D0", Slot = "20")]
		public sealed override void OFPFHIBMMCN(byte[] MPPNOBEIAMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5D41F60", Offset = "0x5D41360", VA = "0x185D41F60", Slot = "17")]
		public sealed override void CNFJEHEIBKG()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, FNKIJEGCNHI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x82684C0", Offset = "0x82678C0", VA = "0x1882684C0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8268500", Offset = "0x8267900", VA = "0x188268500", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8268420", Offset = "0x8267820", VA = "0x188268420")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x82683C0", Offset = "0x82677C0", VA = "0x1882683C0")]
		public MutableOverridableListObscuredString(bool PLJOEFBBPNA, List<ObscuredString> CBMEHPPMEEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8268320", Offset = "0x8267720", VA = "0x188268320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8267E60", Offset = "0x8267260", VA = "0x188267E60", Slot = "17")]
		public override void CNFJEHEIBKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8268240", Offset = "0x8267640", VA = "0x188268240", Slot = "20")]
		public override void OFPFHIBMMCN(byte[] MPPNOBEIAMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8267EF0", Offset = "0x82672F0", VA = "0x188267EF0", Slot = "19")]
		public override void KFKKEIEJHKF(FNKIJEGCNHI LBMJEJIFGJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8267C80", Offset = "0x8267080", VA = "0x188267C80", Slot = "18")]
		public override FNKIJEGCNHI CEKOABLGEAG()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : FKCNHJENNHE<Vector3>, HFHDOIIHAHJ
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
			[Cpp2IlInjected.Address(RVA = "0x105C9D0", Offset = "0x105BDD0", VA = "0x18105C9D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8269450", Offset = "0x8268850", VA = "0x188269450", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAD2430", Offset = "0xAD1830", VA = "0x180AD2430", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5924AB0", Offset = "0x5923EB0", VA = "0x185924AB0")]
		public OverridableVector3(Vector3 CBMEHPPMEEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x606AD10", Offset = "0x606A110", VA = "0x18606AD10")]
		public OverridableVector3(bool PLJOEFBBPNA, Vector3 CBMEHPPMEEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x82693B0", Offset = "0x82687B0", VA = "0x1882693B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8269390", Offset = "0x8268790", VA = "0x188269390")]
		public static OverridableVector3 GKKMDDPCKIG(Vector3 DIMKOEFIKCH)
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
