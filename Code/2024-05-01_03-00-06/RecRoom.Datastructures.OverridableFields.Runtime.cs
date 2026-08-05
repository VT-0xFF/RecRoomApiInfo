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
public interface BPJDAFALKNN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FKLBGCGIICP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object POFJFCHCIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CHBOCCNLIFE<T> : BPJDAFALKNN
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T ACOGNAIJGCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface DNEHIDLGKGF<T> : CHBOCCNLIFE<T>, BPJDAFALKNN
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool FKLBGCGIICP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T ACOGNAIJGCD
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
public interface HBEICBCHIJC<T> : DNEHIDLGKGF<T>, CHBOCCNLIFE<T>, BPJDAFALKNN
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool BALNOIOPKPP
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
	public struct OverridableInt : CHBOCCNLIFE<int>, BPJDAFALKNN
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
			[Cpp2IlInjected.Address(RVA = "0x1B8FDB0", Offset = "0x1B8EBB0", VA = "0x181B8FDB0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x61E7370", Offset = "0x61E6170", VA = "0x1861E7370", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2373060", Offset = "0x2371E60", VA = "0x182373060", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x61E72D0", Offset = "0x61E60D0", VA = "0x1861E72D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : CHBOCCNLIFE<string>, BPJDAFALKNN
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
			[Cpp2IlInjected.Address(RVA = "0x1B8FDB0", Offset = "0x1B8EBB0", VA = "0x181B8FDB0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9007C0", Offset = "0x8FF5C0", VA = "0x1809007C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9007C0", Offset = "0x8FF5C0", VA = "0x1809007C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x61E73C0", Offset = "0x61E61C0", VA = "0x1861E73C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : DNEHIDLGKGF<InnerType>, CHBOCCNLIFE<InnerType>, BPJDAFALKNN where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool FKLBGCGIICP
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType ACOGNAIJGCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object POFJFCHCIJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x1FB0330", Offset = "0x1FAF130", VA = "0x181FB0330", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3FF1A40", Offset = "0x3FF0840", VA = "0x183FF1A40")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3FF1A70", Offset = "0x3FF0870", VA = "0x183FF1A70")]
		public MutableOverridableBase(bool EDKMMCGHLDI, [NotNull] InnerType DIBNBLEEFNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3FF1020", Offset = "0x3FEFE20", VA = "0x183FF1020", Slot = "15")]
		public void GAOMJGIPJLJ(CHBOCCNLIFE<InnerType> AAAIJIAJNCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3FF1980", Offset = "0x3FF0780", VA = "0x183FF1980", Slot = "16")]
		public void KKGLAFBLIAH(CHBOCCNLIFE<InnerType> GGINNHLAMLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3FF1580", Offset = "0x3FF0380", VA = "0x183FF1580", Slot = "17")]
		public virtual void HJOLGBAAIAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType ECICKGINKII();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void PLCDLMAJCJG(ProtobufType JMPFKCLJFNO);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void JIHJFENDEDD(byte[] FGPOMFPBMCN);
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
			[Cpp2IlInjected.Address(RVA = "0x801870", Offset = "0x800670", VA = "0x180801870", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8682F0", Offset = "0x8670F0", VA = "0x1808682F0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1A8D250", Offset = "0x1A8C050", VA = "0x181A8D250", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3471EA0", Offset = "0x3470CA0", VA = "0x183471EA0")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3DAE250", Offset = "0x3DAD050", VA = "0x183DAE250")]
		public SerializedMutableOverridableBase(bool EDKMMCGHLDI, InnerType DIBNBLEEFNN)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, HGDKLBJMDMP>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x61E7200", Offset = "0x61E6000", VA = "0x1861E7200")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x61E7260", Offset = "0x61E6060", VA = "0x1861E7260")]
		public MutableOverridableObscuredInt(bool EDKMMCGHLDI, ObscuredInt DIBNBLEEFNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x61E7130", Offset = "0x61E5F30", VA = "0x1861E7130", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x61E6FB0", Offset = "0x61E5DB0", VA = "0x1861E6FB0", Slot = "20")]
		public override void JIHJFENDEDD(byte[] FGPOMFPBMCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x61E7080", Offset = "0x61E5E80", VA = "0x1861E7080", Slot = "19")]
		public override void PLCDLMAJCJG(HGDKLBJMDMP JMPFKCLJFNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x61E6ED0", Offset = "0x61E5CD0", VA = "0x1861E6ED0", Slot = "18")]
		public override HGDKLBJMDMP ECICKGINKII()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, PJCANOIOIOL>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x61E6E00", Offset = "0x61E5C00", VA = "0x1861E6E00")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x61E6E60", Offset = "0x61E5C60", VA = "0x1861E6E60")]
		public MutableOverridableObscuredFloat(bool EDKMMCGHLDI, ObscuredFloat DIBNBLEEFNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x61E6D30", Offset = "0x61E5B30", VA = "0x1861E6D30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x61E6BA0", Offset = "0x61E59A0", VA = "0x1861E6BA0", Slot = "20")]
		public override void JIHJFENDEDD(byte[] FGPOMFPBMCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x61E6C70", Offset = "0x61E5A70", VA = "0x1861E6C70", Slot = "19")]
		public override void PLCDLMAJCJG(PJCANOIOIOL JMPFKCLJFNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x61E6AB0", Offset = "0x61E58B0", VA = "0x1861E6AB0", Slot = "18")]
		public override PJCANOIOIOL ECICKGINKII()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, FMNDHGJHAOP>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x61E5CF0", Offset = "0x61E4AF0", VA = "0x1861E5CF0")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x61E6A40", Offset = "0x61E5840", VA = "0x1861E6A40")]
		public MutableOverridableObscuredBool(bool EDKMMCGHLDI, ObscuredBool DIBNBLEEFNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x61E6970", Offset = "0x61E5770", VA = "0x1861E6970", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x61E6750", Offset = "0x61E5550", VA = "0x1861E6750", Slot = "20")]
		public override void JIHJFENDEDD(byte[] FGPOMFPBMCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x61E68B0", Offset = "0x61E56B0", VA = "0x1861E68B0", Slot = "19")]
		public override void PLCDLMAJCJG(FMNDHGJHAOP JMPFKCLJFNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x61E6660", Offset = "0x61E5460", VA = "0x1861E6660", Slot = "18")]
		public override FMNDHGJHAOP ECICKGINKII()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x61E6820", Offset = "0x61E5620", VA = "0x1861E6820", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, HBEICBCHIJC<ObscuredBool>, DNEHIDLGKGF<ObscuredBool>, CHBOCCNLIFE<ObscuredBool>, BPJDAFALKNN
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7BA880", Offset = "0x7B9680", VA = "0x1807BA880", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7BA890", Offset = "0x7B9690", VA = "0x1807BA890", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x61E5CF0", Offset = "0x61E4AF0", VA = "0x1861E5CF0")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x61E5C70", Offset = "0x61E4A70", VA = "0x1861E5C70")]
		public void GAOMJGIPJLJ(MutableOverridableDefaultableObscuredBool GGINNHLAMLI)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, HGDKLBJMDMP> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x43FDD10", Offset = "0x43FCB10", VA = "0x1843FDD10", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x43FDE20", Offset = "0x43FCC20", VA = "0x1843FDE20", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3A85140", Offset = "0x3A83F40", VA = "0x183A85140")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x43FDCF0", Offset = "0x43FCAF0", VA = "0x1843FDCF0")]
		public SerializedMutableOverridableObscuredEnum(bool EDKMMCGHLDI, TObsEnum DIBNBLEEFNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x43FD9B0", Offset = "0x43FC7B0", VA = "0x1843FD9B0", Slot = "18")]
		public sealed override HGDKLBJMDMP ECICKGINKII()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x43FDBF0", Offset = "0x43FC9F0", VA = "0x1843FDBF0", Slot = "19")]
		public sealed override void PLCDLMAJCJG(HGDKLBJMDMP JMPFKCLJFNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x43FDB10", Offset = "0x43FC910", VA = "0x1843FDB10", Slot = "20")]
		public sealed override void JIHJFENDEDD(byte[] FGPOMFPBMCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x43FDAA0", Offset = "0x43FC8A0", VA = "0x1843FDAA0", Slot = "17")]
		public sealed override void HJOLGBAAIAG()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, BBHPAIOIFEG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x61E6590", Offset = "0x61E5390", VA = "0x1861E6590", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x61E65D0", Offset = "0x61E53D0", VA = "0x1861E65D0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x61E64F0", Offset = "0x61E52F0", VA = "0x1861E64F0")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x61E6490", Offset = "0x61E5290", VA = "0x1861E6490")]
		public MutableOverridableListObscuredString(bool EDKMMCGHLDI, List<ObscuredString> DIBNBLEEFNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x61E63F0", Offset = "0x61E51F0", VA = "0x1861E63F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x61E5F40", Offset = "0x61E4D40", VA = "0x1861E5F40", Slot = "17")]
		public override void HJOLGBAAIAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x61E5FD0", Offset = "0x61E4DD0", VA = "0x1861E5FD0", Slot = "20")]
		public override void JIHJFENDEDD(byte[] FGPOMFPBMCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x61E60A0", Offset = "0x61E4EA0", VA = "0x1861E60A0", Slot = "19")]
		public override void PLCDLMAJCJG(BBHPAIOIFEG JMPFKCLJFNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x61E5D60", Offset = "0x61E4B60", VA = "0x1861E5D60", Slot = "18")]
		public override BBHPAIOIFEG ECICKGINKII()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : CHBOCCNLIFE<Vector3>, BPJDAFALKNN
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
			[Cpp2IlInjected.Address(RVA = "0x1B8FDB0", Offset = "0x1B8EBB0", VA = "0x181B8FDB0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x61E74F0", Offset = "0x61E62F0", VA = "0x1861E74F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x3DA0650", Offset = "0x3D9F450", VA = "0x183DA0650", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x40DB720", Offset = "0x40DA520", VA = "0x1840DB720")]
		public OverridableVector3(Vector3 DIBNBLEEFNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4623960", Offset = "0x4622760", VA = "0x184623960")]
		public OverridableVector3(bool EDKMMCGHLDI, Vector3 DIBNBLEEFNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x61E7450", Offset = "0x61E6250", VA = "0x1861E7450", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x61E7430", Offset = "0x61E6230", VA = "0x1861E7430")]
		public static OverridableVector3 BPFJNEHKLMP(Vector3 FLOENDBPFOD)
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
