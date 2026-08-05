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
public interface EOMIFAAOGKD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool IOMLHDNKPDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object OHJIFAEPOGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DHJNKLBAIAE<T> : EOMIFAAOGKD
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T FJJHODHBEGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface DNICAPOBIJJ<T> : DHJNKLBAIAE<T>, EOMIFAAOGKD
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool IOMLHDNKPDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T FJJHODHBEGH
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
public interface PDALBALGFPL<T> : DNICAPOBIJJ<T>, DHJNKLBAIAE<T>, EOMIFAAOGKD
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool LPPGAJKNJED
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
	public struct OverridableInt : DHJNKLBAIAE<int>, EOMIFAAOGKD
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
			[Cpp2IlInjected.Address(RVA = "0x1BA55B0", Offset = "0x1BA47B0", VA = "0x181BA55B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x61BEB70", Offset = "0x61BDD70", VA = "0x1861BEB70", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x238FDE0", Offset = "0x238EFE0", VA = "0x18238FDE0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x61BEAD0", Offset = "0x61BDCD0", VA = "0x1861BEAD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : DHJNKLBAIAE<string>, EOMIFAAOGKD
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
			[Cpp2IlInjected.Address(RVA = "0x1BA55B0", Offset = "0x1BA47B0", VA = "0x181BA55B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9154B0", Offset = "0x9146B0", VA = "0x1809154B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9154B0", Offset = "0x9146B0", VA = "0x1809154B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x61BEBC0", Offset = "0x61BDDC0", VA = "0x1861BEBC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : DNICAPOBIJJ<InnerType>, DHJNKLBAIAE<InnerType>, EOMIFAAOGKD where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool IOMLHDNKPDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType FJJHODHBEGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object OHJIFAEPOGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x1FC8430", Offset = "0x1FC7630", VA = "0x181FC8430", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3FDFA80", Offset = "0x3FDEC80", VA = "0x183FDFA80")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3FDFAB0", Offset = "0x3FDECB0", VA = "0x183FDFAB0")]
		public MutableOverridableBase(bool AKMGCAHOMOI, [NotNull] InnerType NICEPFIEJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3FDF1B0", Offset = "0x3FDE3B0", VA = "0x183FDF1B0", Slot = "15")]
		public void AEHNPEACLCA(DHJNKLBAIAE<InnerType> DAHPNHMLECN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3FDF650", Offset = "0x3FDE850", VA = "0x183FDF650", Slot = "16")]
		public void GMJOKEELPME(DHJNKLBAIAE<InnerType> NOBJAPGNDAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3FDF930", Offset = "0x3FDEB30", VA = "0x183FDF930", Slot = "17")]
		public virtual void MNHGCJGIAKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType JLINLAAMHMN();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void EAGDLIACMJL(ProtobufType JJCIOGGMGGH);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void NGOJNOGGJML(byte[] JEPOOHDEOJB);
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
			[Cpp2IlInjected.Address(RVA = "0x827680", Offset = "0x826880", VA = "0x180827680", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x88CAB0", Offset = "0x88BCB0", VA = "0x18088CAB0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1AAA710", Offset = "0x1AA9910", VA = "0x181AAA710", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3993840", Offset = "0x3992A40", VA = "0x183993840")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x427CCA0", Offset = "0x427BEA0", VA = "0x18427CCA0")]
		public SerializedMutableOverridableBase(bool AKMGCAHOMOI, InnerType NICEPFIEJED)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, FJNCHNFCBFP>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x61BEA00", Offset = "0x61BDC00", VA = "0x1861BEA00")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x61BEA60", Offset = "0x61BDC60", VA = "0x1861BEA60")]
		public MutableOverridableObscuredInt(bool AKMGCAHOMOI, ObscuredInt NICEPFIEJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x61BE930", Offset = "0x61BDB30", VA = "0x1861BE930", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x61BE860", Offset = "0x61BDA60", VA = "0x1861BE860", Slot = "20")]
		public override void NGOJNOGGJML(byte[] JEPOOHDEOJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x61BE6D0", Offset = "0x61BD8D0", VA = "0x1861BE6D0", Slot = "19")]
		public override void EAGDLIACMJL(FJNCHNFCBFP JJCIOGGMGGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x61BE780", Offset = "0x61BD980", VA = "0x1861BE780", Slot = "18")]
		public override FJNCHNFCBFP JLINLAAMHMN()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, NJANKEBACNL>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x61BE600", Offset = "0x61BD800", VA = "0x1861BE600")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x61BE660", Offset = "0x61BD860", VA = "0x1861BE660")]
		public MutableOverridableObscuredFloat(bool AKMGCAHOMOI, ObscuredFloat NICEPFIEJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x61BE530", Offset = "0x61BD730", VA = "0x1861BE530", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x61BE460", Offset = "0x61BD660", VA = "0x1861BE460", Slot = "20")]
		public override void NGOJNOGGJML(byte[] JEPOOHDEOJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x61BE2B0", Offset = "0x61BD4B0", VA = "0x1861BE2B0", Slot = "19")]
		public override void EAGDLIACMJL(NJANKEBACNL JJCIOGGMGGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x61BE370", Offset = "0x61BD570", VA = "0x1861BE370", Slot = "18")]
		public override NJANKEBACNL JLINLAAMHMN()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, LJBHELOJOLO>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x61BD4E0", Offset = "0x61BC6E0", VA = "0x1861BD4E0")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x61BE240", Offset = "0x61BD440", VA = "0x1861BE240")]
		public MutableOverridableObscuredBool(bool AKMGCAHOMOI, ObscuredBool NICEPFIEJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x61BE170", Offset = "0x61BD370", VA = "0x1861BE170", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x61BE010", Offset = "0x61BD210", VA = "0x1861BE010", Slot = "20")]
		public override void NGOJNOGGJML(byte[] JEPOOHDEOJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x61BDE60", Offset = "0x61BD060", VA = "0x1861BDE60", Slot = "19")]
		public override void EAGDLIACMJL(LJBHELOJOLO JJCIOGGMGGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x61BDF20", Offset = "0x61BD120", VA = "0x1861BDF20", Slot = "18")]
		public override LJBHELOJOLO JLINLAAMHMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x61BE0E0", Offset = "0x61BD2E0", VA = "0x1861BE0E0", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, PDALBALGFPL<ObscuredBool>, DNICAPOBIJJ<ObscuredBool>, DHJNKLBAIAE<ObscuredBool>, EOMIFAAOGKD
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7B62E0", Offset = "0x7B54E0", VA = "0x1807B62E0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7B6000", Offset = "0x7B5200", VA = "0x1807B6000", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x61BD4E0", Offset = "0x61BC6E0", VA = "0x1861BD4E0")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x61BD460", Offset = "0x61BC660", VA = "0x1861BD460")]
		public void AEHNPEACLCA(MutableOverridableDefaultableObscuredBool NOBJAPGNDAK)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, FJNCHNFCBFP> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x443D570", Offset = "0x443C770", VA = "0x18443D570", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x443D680", Offset = "0x443C880", VA = "0x18443D680", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x37FA320", Offset = "0x37F9520", VA = "0x1837FA320")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x443D550", Offset = "0x443C750", VA = "0x18443D550")]
		public SerializedMutableOverridableObscuredEnum(bool AKMGCAHOMOI, TObsEnum NICEPFIEJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x443D310", Offset = "0x443C510", VA = "0x18443D310", Slot = "18")]
		public sealed override FJNCHNFCBFP JLINLAAMHMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x443D210", Offset = "0x443C410", VA = "0x18443D210", Slot = "19")]
		public sealed override void EAGDLIACMJL(FJNCHNFCBFP JJCIOGGMGGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x443D470", Offset = "0x443C670", VA = "0x18443D470", Slot = "20")]
		public sealed override void NGOJNOGGJML(byte[] JEPOOHDEOJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x443D400", Offset = "0x443C600", VA = "0x18443D400", Slot = "17")]
		public sealed override void MNHGCJGIAKL()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, OJBPAOBGHED>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x61BDD90", Offset = "0x61BCF90", VA = "0x1861BDD90", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x61BDDD0", Offset = "0x61BCFD0", VA = "0x1861BDDD0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x61BDCF0", Offset = "0x61BCEF0", VA = "0x1861BDCF0")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x61BDC90", Offset = "0x61BCE90", VA = "0x1861BDC90")]
		public MutableOverridableListObscuredString(bool AKMGCAHOMOI, List<ObscuredString> NICEPFIEJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x61BDBF0", Offset = "0x61BCDF0", VA = "0x1861BDBF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x61BDA90", Offset = "0x61BCC90", VA = "0x1861BDA90", Slot = "17")]
		public override void MNHGCJGIAKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x61BDB20", Offset = "0x61BCD20", VA = "0x1861BDB20", Slot = "20")]
		public override void NGOJNOGGJML(byte[] JEPOOHDEOJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x61BD550", Offset = "0x61BC750", VA = "0x1861BD550", Slot = "19")]
		public override void EAGDLIACMJL(OJBPAOBGHED JJCIOGGMGGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x61BD8B0", Offset = "0x61BCAB0", VA = "0x1861BD8B0", Slot = "18")]
		public override OJBPAOBGHED JLINLAAMHMN()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : DHJNKLBAIAE<Vector3>, EOMIFAAOGKD
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
			[Cpp2IlInjected.Address(RVA = "0x1BA55B0", Offset = "0x1BA47B0", VA = "0x181BA55B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x61BECF0", Offset = "0x61BDEF0", VA = "0x1861BECF0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x3D10870", Offset = "0x3D0FA70", VA = "0x183D10870", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4115E80", Offset = "0x4115080", VA = "0x184115E80")]
		public OverridableVector3(Vector3 NICEPFIEJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x466C5B0", Offset = "0x466B7B0", VA = "0x18466C5B0")]
		public OverridableVector3(bool AKMGCAHOMOI, Vector3 NICEPFIEJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x61BEC50", Offset = "0x61BDE50", VA = "0x1861BEC50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x61BEC30", Offset = "0x61BDE30", VA = "0x1861BEC30")]
		public static OverridableVector3 LOOIAEAGNBK(Vector3 LJPPKNAEGOB)
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
