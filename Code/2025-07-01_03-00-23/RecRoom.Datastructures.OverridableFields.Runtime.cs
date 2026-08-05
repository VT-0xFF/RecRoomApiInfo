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
public interface HCCMMHLEOAI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NPFPOHAFEOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object MNEOHBLPOKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OGBDIBILHMB<T> : HCCMMHLEOAI
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T IBMJNNAJGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface MJBOKJEBHKH<T> : OGBDIBILHMB<T>, HCCMMHLEOAI
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool NPFPOHAFEOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T IBMJNNAJGNM
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
public interface PNIHFACNKGH<T> : MJBOKJEBHKH<T>, OGBDIBILHMB<T>, HCCMMHLEOAI
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool ELMKGPDANJM
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
	public struct OverridableInt : OGBDIBILHMB<int>, HCCMMHLEOAI
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
			[Cpp2IlInjected.Address(RVA = "0xFC3720", Offset = "0xFC1D20", VA = "0x180FC3720", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7F6CFE0", Offset = "0x7F6B5E0", VA = "0x187F6CFE0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x306D380", Offset = "0x306B980", VA = "0x18306D380", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7F6CF40", Offset = "0x7F6B540", VA = "0x187F6CF40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : OGBDIBILHMB<string>, HCCMMHLEOAI
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
			[Cpp2IlInjected.Address(RVA = "0xFC3720", Offset = "0xFC1D20", VA = "0x180FC3720", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xE5FAD0", Offset = "0xE5E0D0", VA = "0x180E5FAD0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xE5FAD0", Offset = "0xE5E0D0", VA = "0x180E5FAD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7F6D030", Offset = "0x7F6B630", VA = "0x187F6D030", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : MJBOKJEBHKH<InnerType>, OGBDIBILHMB<InnerType>, HCCMMHLEOAI where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool NPFPOHAFEOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType IBMJNNAJGNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object MNEOHBLPOKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2BAB1C0", Offset = "0x2BA97C0", VA = "0x182BAB1C0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5676A80", Offset = "0x5675080", VA = "0x185676A80")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5676AB0", Offset = "0x56750B0", VA = "0x185676AB0")]
		public MutableOverridableBase(bool JLEPNHHGBMJ, [NotNull] InnerType KKGBKLFKCPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5676170", Offset = "0x5674770", VA = "0x185676170", Slot = "15")]
		public void IMDCLABPHGF(OGBDIBILHMB<InnerType> HBGAGONLKKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5676870", Offset = "0x5674E70", VA = "0x185676870", Slot = "16")]
		public void KOBGMGDADOJ(OGBDIBILHMB<InnerType> HOPHFOOKMCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x56769F0", Offset = "0x5674FF0", VA = "0x1856769F0", Slot = "17")]
		public virtual void MGCNIAHBIMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType LEPIFMPJKPP();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void KHEOADDBNKE(ProtobufType PABLKPAKAOD);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void BGINIBBGJBM(byte[] CCCLPDEILBO);
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
			[Cpp2IlInjected.Address(RVA = "0xAC2F90", Offset = "0xAC1590", VA = "0x180AC2F90", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xAC2F80", Offset = "0xAC1580", VA = "0x180AC2F80", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xE8E950", Offset = "0xE8CF50", VA = "0x180E8E950", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4724F50", Offset = "0x4723550", VA = "0x184724F50")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5B0B6C0", Offset = "0x5B09CC0", VA = "0x185B0B6C0")]
		public SerializedMutableOverridableBase(bool JLEPNHHGBMJ, InnerType KKGBKLFKCPO)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, PGPJMPGOJPC>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7F6CE70", Offset = "0x7F6B470", VA = "0x187F6CE70")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7F6CED0", Offset = "0x7F6B4D0", VA = "0x187F6CED0")]
		public MutableOverridableObscuredInt(bool JLEPNHHGBMJ, ObscuredInt KKGBKLFKCPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7F6CDA0", Offset = "0x7F6B3A0", VA = "0x187F6CDA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7F6CB30", Offset = "0x7F6B130", VA = "0x187F6CB30", Slot = "20")]
		public override void BGINIBBGJBM(byte[] CCCLPDEILBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7F6CC10", Offset = "0x7F6B210", VA = "0x187F6CC10", Slot = "19")]
		public override void KHEOADDBNKE(PGPJMPGOJPC PABLKPAKAOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7F6CCC0", Offset = "0x7F6B2C0", VA = "0x187F6CCC0", Slot = "18")]
		public override PGPJMPGOJPC LEPIFMPJKPP()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, EGAHHELJBOL>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7F6CA60", Offset = "0x7F6B060", VA = "0x187F6CA60")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7F6CAC0", Offset = "0x7F6B0C0", VA = "0x187F6CAC0")]
		public MutableOverridableObscuredFloat(bool JLEPNHHGBMJ, ObscuredFloat KKGBKLFKCPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7F6C990", Offset = "0x7F6AF90", VA = "0x187F6C990", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7F6C700", Offset = "0x7F6AD00", VA = "0x187F6C700", Slot = "20")]
		public override void BGINIBBGJBM(byte[] CCCLPDEILBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7F6C7E0", Offset = "0x7F6ADE0", VA = "0x187F6C7E0", Slot = "19")]
		public override void KHEOADDBNKE(EGAHHELJBOL PABLKPAKAOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7F6C8A0", Offset = "0x7F6AEA0", VA = "0x187F6C8A0", Slot = "18")]
		public override EGAHHELJBOL LEPIFMPJKPP()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, EOIPLNKEKPI>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7F6B920", Offset = "0x7F69F20", VA = "0x187F6B920")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7F6C690", Offset = "0x7F6AC90", VA = "0x187F6C690")]
		public MutableOverridableObscuredBool(bool JLEPNHHGBMJ, ObscuredBool KKGBKLFKCPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7F6C5C0", Offset = "0x7F6ABC0", VA = "0x187F6C5C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7F6C2A0", Offset = "0x7F6A8A0", VA = "0x187F6C2A0", Slot = "20")]
		public override void BGINIBBGJBM(byte[] CCCLPDEILBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7F6C380", Offset = "0x7F6A980", VA = "0x187F6C380", Slot = "19")]
		public override void KHEOADDBNKE(EOIPLNKEKPI PABLKPAKAOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7F6C440", Offset = "0x7F6AA40", VA = "0x187F6C440", Slot = "18")]
		public override EOIPLNKEKPI LEPIFMPJKPP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7F6C530", Offset = "0x7F6AB30", VA = "0x187F6C530", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, PNIHFACNKGH<ObscuredBool>, MJBOKJEBHKH<ObscuredBool>, OGBDIBILHMB<ObscuredBool>, HCCMMHLEOAI
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA50EA0", Offset = "0xA4F4A0", VA = "0x180A50EA0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA50E40", Offset = "0xA4F440", VA = "0x180A50E40", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7F6B920", Offset = "0x7F69F20", VA = "0x187F6B920")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7F6B8A0", Offset = "0x7F69EA0", VA = "0x187F6B8A0")]
		public void IMDCLABPHGF(MutableOverridableDefaultableObscuredBool HOPHFOOKMCC)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, PGPJMPGOJPC> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x5B0BAE0", Offset = "0x5B0A0E0", VA = "0x185B0BAE0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x5B0BC10", Offset = "0x5B0A210", VA = "0x185B0BC10", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4BF2250", Offset = "0x4BF0850", VA = "0x184BF2250")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5B0BAC0", Offset = "0x5B0A0C0", VA = "0x185B0BAC0")]
		public SerializedMutableOverridableObscuredEnum(bool JLEPNHHGBMJ, TObsEnum KKGBKLFKCPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5B0B960", Offset = "0x5B09F60", VA = "0x185B0B960", Slot = "18")]
		public sealed override PGPJMPGOJPC LEPIFMPJKPP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5B0B860", Offset = "0x5B09E60", VA = "0x185B0B860", Slot = "19")]
		public sealed override void KHEOADDBNKE(PGPJMPGOJPC PABLKPAKAOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5B0B780", Offset = "0x5B09D80", VA = "0x185B0B780", Slot = "20")]
		public sealed override void BGINIBBGJBM(byte[] CCCLPDEILBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5B0BA50", Offset = "0x5B0A050", VA = "0x185B0BA50", Slot = "17")]
		public sealed override void MGCNIAHBIMM()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, EBGENPAEJNM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7F6C1D0", Offset = "0x7F6A7D0", VA = "0x187F6C1D0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7F6C210", Offset = "0x7F6A810", VA = "0x187F6C210", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7F6C130", Offset = "0x7F6A730", VA = "0x187F6C130")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7F6C0D0", Offset = "0x7F6A6D0", VA = "0x187F6C0D0")]
		public MutableOverridableListObscuredString(bool JLEPNHHGBMJ, List<ObscuredString> KKGBKLFKCPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7F6C030", Offset = "0x7F6A630", VA = "0x187F6C030", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7F6BFA0", Offset = "0x7F6A5A0", VA = "0x187F6BFA0", Slot = "17")]
		public override void MGCNIAHBIMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7F6B990", Offset = "0x7F69F90", VA = "0x187F6B990", Slot = "20")]
		public override void BGINIBBGJBM(byte[] CCCLPDEILBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7F6BA70", Offset = "0x7F6A070", VA = "0x187F6BA70", Slot = "19")]
		public override void KHEOADDBNKE(EBGENPAEJNM PABLKPAKAOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7F6BDC0", Offset = "0x7F6A3C0", VA = "0x187F6BDC0", Slot = "18")]
		public override EBGENPAEJNM LEPIFMPJKPP()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : OGBDIBILHMB<Vector3>, HCCMMHLEOAI
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
			[Cpp2IlInjected.Address(RVA = "0xFC3720", Offset = "0xFC1D20", VA = "0x180FC3720", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7F6D160", Offset = "0x7F6B760", VA = "0x187F6D160", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5370EB0", Offset = "0x536F4B0", VA = "0x185370EB0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5780E90", Offset = "0x577F490", VA = "0x185780E90")]
		public OverridableVector3(Vector3 KKGBKLFKCPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5E38420", Offset = "0x5E36A20", VA = "0x185E38420")]
		public OverridableVector3(bool JLEPNHHGBMJ, Vector3 KKGBKLFKCPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7F6D0C0", Offset = "0x7F6B6C0", VA = "0x187F6D0C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7F6D0A0", Offset = "0x7F6B6A0", VA = "0x187F6D0A0")]
		public static OverridableVector3 EIMKEBEILPD(Vector3 FADBOFNILPL)
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
