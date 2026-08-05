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
public interface CPLBHOGCGDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool IPNFAPFAMPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object JLJBPGNOFCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EFMAIMOBOBP<T> : CPLBHOGCGDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T EPAONLOANJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GOCEOBPIPNA<T> : EFMAIMOBOBP<T>, CPLBHOGCGDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool IPNFAPFAMPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T EPAONLOANJK
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
public interface LBJDCGGOEME<T> : GOCEOBPIPNA<T>, EFMAIMOBOBP<T>, CPLBHOGCGDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool CPNDKPCCLMG
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
	public struct OverridableInt : EFMAIMOBOBP<int>, CPLBHOGCGDJ
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
			[Cpp2IlInjected.Address(RVA = "0x1D4EB50", Offset = "0x1D4D750", VA = "0x181D4EB50", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x68A2140", Offset = "0x68A0D40", VA = "0x1868A2140", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x251F470", Offset = "0x251E070", VA = "0x18251F470", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x68A20A0", Offset = "0x68A0CA0", VA = "0x1868A20A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : EFMAIMOBOBP<string>, CPLBHOGCGDJ
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
			[Cpp2IlInjected.Address(RVA = "0x1D4EB50", Offset = "0x1D4D750", VA = "0x181D4EB50", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8B4DA0", Offset = "0x8B39A0", VA = "0x1808B4DA0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8B4DA0", Offset = "0x8B39A0", VA = "0x1808B4DA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x68A2190", Offset = "0x68A0D90", VA = "0x1868A2190", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : GOCEOBPIPNA<InnerType>, EFMAIMOBOBP<InnerType>, CPLBHOGCGDJ where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool IPNFAPFAMPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType EPAONLOANJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object JLJBPGNOFCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x211A710", Offset = "0x2119310", VA = "0x18211A710", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x447BAF0", Offset = "0x447A6F0", VA = "0x18447BAF0")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x447BB20", Offset = "0x447A720", VA = "0x18447BB20")]
		public MutableOverridableBase(bool JPBCOKFJHDJ, [NotNull] InnerType GLMEMJNJKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x447BA30", Offset = "0x447A630", VA = "0x18447BA30", Slot = "15")]
		public void IABHGAFBONO(EFMAIMOBOBP<InnerType> HCOPCPFHNHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x447B580", Offset = "0x447A180", VA = "0x18447B580", Slot = "16")]
		public void AIIIFAEPLFO(EFMAIMOBOBP<InnerType> OCNJFCPHJLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x447B640", Offset = "0x447A240", VA = "0x18447B640", Slot = "17")]
		public virtual void CJMFGDFICPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType CGCDIGHHNNE();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void HOPGCGPFDNN(ProtobufType DHOANMENAEB);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void DIAILAIHPEO(byte[] OIGIGEDMJIO);
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
			[Cpp2IlInjected.Address(RVA = "0x897580", Offset = "0x896180", VA = "0x180897580", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x99DDA0", Offset = "0x99C9A0", VA = "0x18099DDA0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1C2F280", Offset = "0x1C2DE80", VA = "0x181C2F280", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3C733C0", Offset = "0x3C71FC0", VA = "0x183C733C0")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x406EE30", Offset = "0x406DA30", VA = "0x18406EE30")]
		public SerializedMutableOverridableBase(bool JPBCOKFJHDJ, InnerType GLMEMJNJKAN)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, IEACAHDGGDE>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x68A1FD0", Offset = "0x68A0BD0", VA = "0x1868A1FD0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x68A2030", Offset = "0x68A0C30", VA = "0x1868A2030")]
		public MutableOverridableObscuredInt(bool JPBCOKFJHDJ, ObscuredInt GLMEMJNJKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x68A1F00", Offset = "0x68A0B00", VA = "0x1868A1F00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x68A1D70", Offset = "0x68A0970", VA = "0x1868A1D70", Slot = "20")]
		public override void DIAILAIHPEO(byte[] OIGIGEDMJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x68A1E50", Offset = "0x68A0A50", VA = "0x1868A1E50", Slot = "19")]
		public override void HOPGCGPFDNN(IEACAHDGGDE DHOANMENAEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x68A1C90", Offset = "0x68A0890", VA = "0x1868A1C90", Slot = "18")]
		public override IEACAHDGGDE CGCDIGHHNNE()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, OOPGJJGBLBG>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x68A1BC0", Offset = "0x68A07C0", VA = "0x1868A1BC0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x68A1C20", Offset = "0x68A0820", VA = "0x1868A1C20")]
		public MutableOverridableObscuredFloat(bool JPBCOKFJHDJ, ObscuredFloat GLMEMJNJKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x68A1AF0", Offset = "0x68A06F0", VA = "0x1868A1AF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x68A1950", Offset = "0x68A0550", VA = "0x1868A1950", Slot = "20")]
		public override void DIAILAIHPEO(byte[] OIGIGEDMJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x68A1A30", Offset = "0x68A0630", VA = "0x1868A1A30", Slot = "19")]
		public override void HOPGCGPFDNN(OOPGJJGBLBG DHOANMENAEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x68A1860", Offset = "0x68A0460", VA = "0x1868A1860", Slot = "18")]
		public override OOPGJJGBLBG CGCDIGHHNNE()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, JNCHLGIGCFE>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x68A0A60", Offset = "0x689F660", VA = "0x1868A0A60")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x68A17F0", Offset = "0x68A03F0", VA = "0x1868A17F0")]
		public MutableOverridableObscuredBool(bool JPBCOKFJHDJ, ObscuredBool GLMEMJNJKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x68A1720", Offset = "0x68A0320", VA = "0x1868A1720", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x68A14F0", Offset = "0x68A00F0", VA = "0x1868A14F0", Slot = "20")]
		public override void DIAILAIHPEO(byte[] OIGIGEDMJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x68A15D0", Offset = "0x68A01D0", VA = "0x1868A15D0", Slot = "19")]
		public override void HOPGCGPFDNN(JNCHLGIGCFE DHOANMENAEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x68A1400", Offset = "0x68A0000", VA = "0x1868A1400", Slot = "18")]
		public override JNCHLGIGCFE CGCDIGHHNNE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x68A1690", Offset = "0x68A0290", VA = "0x1868A1690", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, LBJDCGGOEME<ObscuredBool>, GOCEOBPIPNA<ObscuredBool>, EFMAIMOBOBP<ObscuredBool>, CPLBHOGCGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x843300", Offset = "0x841F00", VA = "0x180843300", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8431F0", Offset = "0x841DF0", VA = "0x1808431F0", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x68A0A60", Offset = "0x689F660", VA = "0x1868A0A60")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x68A09E0", Offset = "0x689F5E0", VA = "0x1868A09E0")]
		public void IABHGAFBONO(MutableOverridableDefaultableObscuredBool OCNJFCPHJLD)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, IEACAHDGGDE> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x495E9D0", Offset = "0x495D5D0", VA = "0x18495E9D0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x495EB50", Offset = "0x495D750", VA = "0x18495EB50", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3BAC2B0", Offset = "0x3BAAEB0", VA = "0x183BAC2B0")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x495E990", Offset = "0x495D590", VA = "0x18495E990")]
		public SerializedMutableOverridableObscuredEnum(bool JPBCOKFJHDJ, TObsEnum GLMEMJNJKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x495E640", Offset = "0x495D240", VA = "0x18495E640", Slot = "18")]
		public sealed override IEACAHDGGDE CGCDIGHHNNE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x495E890", Offset = "0x495D490", VA = "0x18495E890", Slot = "19")]
		public sealed override void HOPGCGPFDNN(IEACAHDGGDE DHOANMENAEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x495E7B0", Offset = "0x495D3B0", VA = "0x18495E7B0", Slot = "20")]
		public sealed override void DIAILAIHPEO(byte[] OIGIGEDMJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x495E730", Offset = "0x495D330", VA = "0x18495E730", Slot = "17")]
		public sealed override void CJMFGDFICPO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, IPENCJPPEFJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x68A1330", Offset = "0x689FF30", VA = "0x1868A1330", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x68A1370", Offset = "0x689FF70", VA = "0x1868A1370", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x68A1290", Offset = "0x689FE90", VA = "0x1868A1290")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x68A1230", Offset = "0x689FE30", VA = "0x1868A1230")]
		public MutableOverridableListObscuredString(bool JPBCOKFJHDJ, List<ObscuredString> GLMEMJNJKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x68A1190", Offset = "0x689FD90", VA = "0x1868A1190", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x68A0CB0", Offset = "0x689F8B0", VA = "0x1868A0CB0", Slot = "17")]
		public override void CJMFGDFICPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x68A0D40", Offset = "0x689F940", VA = "0x1868A0D40", Slot = "20")]
		public override void DIAILAIHPEO(byte[] OIGIGEDMJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x68A0E20", Offset = "0x689FA20", VA = "0x1868A0E20", Slot = "19")]
		public override void HOPGCGPFDNN(IPENCJPPEFJ DHOANMENAEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x68A0AD0", Offset = "0x689F6D0", VA = "0x1868A0AD0", Slot = "18")]
		public override IPENCJPPEFJ CGCDIGHHNNE()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : EFMAIMOBOBP<Vector3>, CPLBHOGCGDJ
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
			[Cpp2IlInjected.Address(RVA = "0x1D4EB50", Offset = "0x1D4D750", VA = "0x181D4EB50", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x68A22C0", Offset = "0x68A0EC0", VA = "0x1868A22C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x41E3B30", Offset = "0x41E2730", VA = "0x1841E3B30", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4553750", Offset = "0x4552350", VA = "0x184553750")]
		public OverridableVector3(Vector3 GLMEMJNJKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4BCE190", Offset = "0x4BCCD90", VA = "0x184BCE190")]
		public OverridableVector3(bool JPBCOKFJHDJ, Vector3 GLMEMJNJKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x68A2220", Offset = "0x68A0E20", VA = "0x1868A2220", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x68A2200", Offset = "0x68A0E00", VA = "0x1868A2200")]
		public static OverridableVector3 NBHHLKKAPBL(Vector3 CLJFFIBMODC)
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
