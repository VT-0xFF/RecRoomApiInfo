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
public interface BHNBCPELJOI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EEHIFNDKCGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object IPEALMPLOEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DEAOKGPGNIN<T> : BHNBCPELJOI
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T DFPHMDCMPIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EEIIDJOHJCN<T> : DEAOKGPGNIN<T>, BHNBCPELJOI
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool EEHIFNDKCGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T DFPHMDCMPIO
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
public interface LKHKIEFEMKL<T> : EEIIDJOHJCN<T>, DEAOKGPGNIN<T>, BHNBCPELJOI
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool GAAPNIAEJJP
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
	public struct OverridableInt : DEAOKGPGNIN<int>, BHNBCPELJOI
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
			[Cpp2IlInjected.Address(RVA = "0x1A76520", Offset = "0x1A75320", VA = "0x181A76520", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5FC8F10", Offset = "0x5FC7D10", VA = "0x185FC8F10", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2200D30", Offset = "0x21FFB30", VA = "0x182200D30", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5FC8E70", Offset = "0x5FC7C70", VA = "0x185FC8E70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : DEAOKGPGNIN<string>, BHNBCPELJOI
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
			[Cpp2IlInjected.Address(RVA = "0x1A76520", Offset = "0x1A75320", VA = "0x181A76520", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x898230", Offset = "0x897030", VA = "0x180898230", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x898230", Offset = "0x897030", VA = "0x180898230", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5FC8F60", Offset = "0x5FC7D60", VA = "0x185FC8F60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : EEIIDJOHJCN<InnerType>, DEAOKGPGNIN<InnerType>, BHNBCPELJOI where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool EEHIFNDKCGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType DFPHMDCMPIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object IPEALMPLOEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x21C20F0", Offset = "0x21C0EF0", VA = "0x1821C20F0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3E45190", Offset = "0x3E43F90", VA = "0x183E45190")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3E451C0", Offset = "0x3E43FC0", VA = "0x183E451C0")]
		public MutableOverridableBase(bool CJNKLILLDLJ, [NotNull] InnerType NKKIECLCEML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3E44DC0", Offset = "0x3E43BC0", VA = "0x183E44DC0", Slot = "15")]
		public void MIFFLKPNDLN(DEAOKGPGNIN<InnerType> JIBECFCCCNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3E44C20", Offset = "0x3E43A20", VA = "0x183E44C20", Slot = "16")]
		public void JLEDLPHOJFD(DEAOKGPGNIN<InnerType> FPEEGIOMOFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3E450F0", Offset = "0x3E43EF0", VA = "0x183E450F0", Slot = "17")]
		public virtual void MNGHADJNDMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType IAIJCKOLGKH();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void ECOEALNFPBF(ProtobufType IIJCBCEMIGK);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void HNKKHNFGJMG(byte[] BFOCNAFIGGE);
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
			[Cpp2IlInjected.Address(RVA = "0x7F6320", Offset = "0x7F5120", VA = "0x1807F6320", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x99B200", Offset = "0x99A000", VA = "0x18099B200", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1996A30", Offset = "0x1995830", VA = "0x181996A30", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x32544B0", Offset = "0x32532B0", VA = "0x1832544B0")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x42189C0", Offset = "0x42177C0", VA = "0x1842189C0")]
		public SerializedMutableOverridableBase(bool CJNKLILLDLJ, InnerType NKKIECLCEML)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, CANHCNPFBKF>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5FC8DA0", Offset = "0x5FC7BA0", VA = "0x185FC8DA0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5FC8E00", Offset = "0x5FC7C00", VA = "0x185FC8E00")]
		public MutableOverridableObscuredInt(bool CJNKLILLDLJ, ObscuredInt NKKIECLCEML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5FC8CD0", Offset = "0x5FC7AD0", VA = "0x185FC8CD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5FC8B10", Offset = "0x5FC7910", VA = "0x185FC8B10", Slot = "20")]
		public override void HNKKHNFGJMG(byte[] BFOCNAFIGGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5FC8A60", Offset = "0x5FC7860", VA = "0x185FC8A60", Slot = "19")]
		public override void ECOEALNFPBF(CANHCNPFBKF IIJCBCEMIGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5FC8BF0", Offset = "0x5FC79F0", VA = "0x185FC8BF0", Slot = "18")]
		public override CANHCNPFBKF IAIJCKOLGKH()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, LEKPAMNBEEN>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5FC8990", Offset = "0x5FC7790", VA = "0x185FC8990")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5FC89F0", Offset = "0x5FC77F0", VA = "0x185FC89F0")]
		public MutableOverridableObscuredFloat(bool CJNKLILLDLJ, ObscuredFloat NKKIECLCEML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5FC88C0", Offset = "0x5FC76C0", VA = "0x185FC88C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5FC86F0", Offset = "0x5FC74F0", VA = "0x185FC86F0", Slot = "20")]
		public override void HNKKHNFGJMG(byte[] BFOCNAFIGGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5FC8630", Offset = "0x5FC7430", VA = "0x185FC8630", Slot = "19")]
		public override void ECOEALNFPBF(LEKPAMNBEEN IIJCBCEMIGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5FC87D0", Offset = "0x5FC75D0", VA = "0x185FC87D0", Slot = "18")]
		public override LEKPAMNBEEN IAIJCKOLGKH()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, JOCJJEGBLHC>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7840", Offset = "0x5FC6640", VA = "0x185FC7840")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5FC85C0", Offset = "0x5FC73C0", VA = "0x185FC85C0")]
		public MutableOverridableObscuredBool(bool CJNKLILLDLJ, ObscuredBool NKKIECLCEML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5FC84F0", Offset = "0x5FC72F0", VA = "0x185FC84F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5FC8290", Offset = "0x5FC7090", VA = "0x185FC8290", Slot = "20")]
		public override void HNKKHNFGJMG(byte[] BFOCNAFIGGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5FC81D0", Offset = "0x5FC6FD0", VA = "0x185FC81D0", Slot = "19")]
		public override void ECOEALNFPBF(JOCJJEGBLHC IIJCBCEMIGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5FC8370", Offset = "0x5FC7170", VA = "0x185FC8370", Slot = "18")]
		public override JOCJJEGBLHC IAIJCKOLGKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5FC8460", Offset = "0x5FC7260", VA = "0x185FC8460", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, LKHKIEFEMKL<ObscuredBool>, EEIIDJOHJCN<ObscuredBool>, DEAOKGPGNIN<ObscuredBool>, BHNBCPELJOI
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7AD1C0", Offset = "0x7ABFC0", VA = "0x1807AD1C0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7ACFA0", Offset = "0x7ABDA0", VA = "0x1807ACFA0", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7840", Offset = "0x5FC6640", VA = "0x185FC7840")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5FC77C0", Offset = "0x5FC65C0", VA = "0x185FC77C0")]
		public void MIFFLKPNDLN(MutableOverridableDefaultableObscuredBool FPEEGIOMOFF)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, CANHCNPFBKF> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x4218DE0", Offset = "0x4217BE0", VA = "0x184218DE0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x4218F10", Offset = "0x4217D10", VA = "0x184218F10", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x366EB70", Offset = "0x366D970", VA = "0x18366EB70")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4218DC0", Offset = "0x4217BC0", VA = "0x184218DC0")]
		public SerializedMutableOverridableObscuredEnum(bool CJNKLILLDLJ, TObsEnum NKKIECLCEML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4218C60", Offset = "0x4217A60", VA = "0x184218C60", Slot = "18")]
		public sealed override CANHCNPFBKF IAIJCKOLGKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4218A80", Offset = "0x4217880", VA = "0x184218A80", Slot = "19")]
		public sealed override void ECOEALNFPBF(CANHCNPFBKF IIJCBCEMIGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4218B80", Offset = "0x4217980", VA = "0x184218B80", Slot = "20")]
		public sealed override void HNKKHNFGJMG(byte[] BFOCNAFIGGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4218D50", Offset = "0x4217B50", VA = "0x184218D50", Slot = "17")]
		public sealed override void MNGHADJNDMD()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, FANHAJLDBBL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x5FC8100", Offset = "0x5FC6F00", VA = "0x185FC8100", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x5FC8140", Offset = "0x5FC6F40", VA = "0x185FC8140", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5FC8060", Offset = "0x5FC6E60", VA = "0x185FC8060")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5FC8000", Offset = "0x5FC6E00", VA = "0x185FC8000")]
		public MutableOverridableListObscuredString(bool CJNKLILLDLJ, List<ObscuredString> NKKIECLCEML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7F60", Offset = "0x5FC6D60", VA = "0x185FC7F60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7ED0", Offset = "0x5FC6CD0", VA = "0x185FC7ED0", Slot = "17")]
		public override void MNGHADJNDMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7C10", Offset = "0x5FC6A10", VA = "0x185FC7C10", Slot = "20")]
		public override void HNKKHNFGJMG(byte[] BFOCNAFIGGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5FC78B0", Offset = "0x5FC66B0", VA = "0x185FC78B0", Slot = "19")]
		public override void ECOEALNFPBF(FANHAJLDBBL IIJCBCEMIGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7CF0", Offset = "0x5FC6AF0", VA = "0x185FC7CF0", Slot = "18")]
		public override FANHAJLDBBL IAIJCKOLGKH()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : DEAOKGPGNIN<Vector3>, BHNBCPELJOI
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
			[Cpp2IlInjected.Address(RVA = "0x1A76520", Offset = "0x1A75320", VA = "0x181A76520", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5FC9090", Offset = "0x5FC7E90", VA = "0x185FC9090", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x3B96C60", Offset = "0x3B95A60", VA = "0x183B96C60", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3F35470", Offset = "0x3F34270", VA = "0x183F35470")]
		public OverridableVector3(Vector3 NKKIECLCEML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5FC8FF0", Offset = "0x5FC7DF0", VA = "0x185FC8FF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5FC8FD0", Offset = "0x5FC7DD0", VA = "0x185FC8FD0")]
		public static OverridableVector3 EADAJIFKEOK(Vector3 NGFDKOKHGLC)
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
