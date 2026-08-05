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
public interface PMJJAJFIKEM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool JNJGEBCEHKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object PKGDDCJPBJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface AJHHJIDEHHJ<T> : PMJJAJFIKEM
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T GDCDOMLHCOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface NPJOEAEKEON<T> : AJHHJIDEHHJ<T>, PMJJAJFIKEM
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool JNJGEBCEHKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T GDCDOMLHCOE
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
public interface PCCNJPHFAAN<T> : NPJOEAEKEON<T>, AJHHJIDEHHJ<T>, PMJJAJFIKEM
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool OOIKODNANDO
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
	public struct OverridableInt : AJHHJIDEHHJ<int>, PMJJAJFIKEM
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
			[Cpp2IlInjected.Address(RVA = "0xF136D0", Offset = "0xF11ED0", VA = "0x180F136D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7AEBD60", Offset = "0x7AEA560", VA = "0x187AEBD60", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2DB0CE0", Offset = "0x2DAF4E0", VA = "0x182DB0CE0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7AEBCC0", Offset = "0x7AEA4C0", VA = "0x187AEBCC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : AJHHJIDEHHJ<string>, PMJJAJFIKEM
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
			[Cpp2IlInjected.Address(RVA = "0xF136D0", Offset = "0xF11ED0", VA = "0x180F136D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xD68560", Offset = "0xD66D60", VA = "0x180D68560", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xD68560", Offset = "0xD66D60", VA = "0x180D68560", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7AEBDB0", Offset = "0x7AEA5B0", VA = "0x187AEBDB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : NPJOEAEKEON<InnerType>, AJHHJIDEHHJ<InnerType>, PMJJAJFIKEM where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool JNJGEBCEHKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType GDCDOMLHCOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object PKGDDCJPBJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x29393E0", Offset = "0x2937BE0", VA = "0x1829393E0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x52D7A80", Offset = "0x52D6280", VA = "0x1852D7A80")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x52D7AB0", Offset = "0x52D62B0", VA = "0x1852D7AB0")]
		public MutableOverridableBase(bool DANNHOKBAIC, [NotNull] InnerType OPMIAMEJKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x52D75D0", Offset = "0x52D5DD0", VA = "0x1852D75D0", Slot = "15")]
		public void NGMIFHNBJDA(AJHHJIDEHHJ<InnerType> DGJLLLECKHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x52D7150", Offset = "0x52D5950", VA = "0x1852D7150", Slot = "16")]
		public void MCKFNIJNPJM(AJHHJIDEHHJ<InnerType> PGPJMFPAKOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x52D79E0", Offset = "0x52D61E0", VA = "0x1852D79E0", Slot = "17")]
		public virtual void OMPDHJNPJPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType FBPKLAMOAFK();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void JGBIHFFKAGJ(ProtobufType GKMGIBMAGHB);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void BFBBKBDJING(byte[] BEJAFFBKKHK);
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
			[Cpp2IlInjected.Address(RVA = "0xC47930", Offset = "0xC46130", VA = "0x180C47930", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xC466E0", Offset = "0xC44EE0", VA = "0x180C466E0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xDA7B00", Offset = "0xDA6300", VA = "0x180DA7B00", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x43AA000", Offset = "0x43A8800", VA = "0x1843AA000")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x49E8D50", Offset = "0x49E7550", VA = "0x1849E8D50")]
		public SerializedMutableOverridableBase(bool DANNHOKBAIC, InnerType OPMIAMEJKDH)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, GBHFMCEHNPG>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7AEBBF0", Offset = "0x7AEA3F0", VA = "0x187AEBBF0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7AEBC50", Offset = "0x7AEA450", VA = "0x187AEBC50")]
		public MutableOverridableObscuredInt(bool DANNHOKBAIC, ObscuredInt OPMIAMEJKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7AEBB20", Offset = "0x7AEA320", VA = "0x187AEBB20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7AEB8C0", Offset = "0x7AEA0C0", VA = "0x187AEB8C0", Slot = "20")]
		public override void BFBBKBDJING(byte[] BEJAFFBKKHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7AEBA70", Offset = "0x7AEA270", VA = "0x187AEBA70", Slot = "19")]
		public override void JGBIHFFKAGJ(GBHFMCEHNPG GKMGIBMAGHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7AEB990", Offset = "0x7AEA190", VA = "0x187AEB990", Slot = "18")]
		public override GBHFMCEHNPG FBPKLAMOAFK()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, PDCILOMIHIP>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7AEB7F0", Offset = "0x7AE9FF0", VA = "0x187AEB7F0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7AEB850", Offset = "0x7AEA050", VA = "0x187AEB850")]
		public MutableOverridableObscuredFloat(bool DANNHOKBAIC, ObscuredFloat OPMIAMEJKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7AEB720", Offset = "0x7AE9F20", VA = "0x187AEB720", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7AEB4A0", Offset = "0x7AE9CA0", VA = "0x187AEB4A0", Slot = "20")]
		public override void BFBBKBDJING(byte[] BEJAFFBKKHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7AEB660", Offset = "0x7AE9E60", VA = "0x187AEB660", Slot = "19")]
		public override void JGBIHFFKAGJ(PDCILOMIHIP GKMGIBMAGHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7AEB570", Offset = "0x7AE9D70", VA = "0x187AEB570", Slot = "18")]
		public override PDCILOMIHIP FBPKLAMOAFK()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, CLBMOKDPBPF>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7AEA6C0", Offset = "0x7AE8EC0", VA = "0x187AEA6C0")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7AEB430", Offset = "0x7AE9C30", VA = "0x187AEB430")]
		public MutableOverridableObscuredBool(bool DANNHOKBAIC, ObscuredBool OPMIAMEJKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7AEB360", Offset = "0x7AE9B60", VA = "0x187AEB360", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7AEB050", Offset = "0x7AE9850", VA = "0x187AEB050", Slot = "20")]
		public override void BFBBKBDJING(byte[] BEJAFFBKKHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7AEB210", Offset = "0x7AE9A10", VA = "0x187AEB210", Slot = "19")]
		public override void JGBIHFFKAGJ(CLBMOKDPBPF GKMGIBMAGHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7AEB120", Offset = "0x7AE9920", VA = "0x187AEB120", Slot = "18")]
		public override CLBMOKDPBPF FBPKLAMOAFK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7AEB2D0", Offset = "0x7AE9AD0", VA = "0x187AEB2D0", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, PCCNJPHFAAN<ObscuredBool>, NPJOEAEKEON<ObscuredBool>, AJHHJIDEHHJ<ObscuredBool>, PMJJAJFIKEM
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x9E0E00", Offset = "0x9DF600", VA = "0x1809E0E00", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9E0E10", Offset = "0x9DF610", VA = "0x1809E0E10", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7AEA6C0", Offset = "0x7AE8EC0", VA = "0x187AEA6C0")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7AEA640", Offset = "0x7AE8E40", VA = "0x187AEA640")]
		public void NGMIFHNBJDA(MutableOverridableDefaultableObscuredBool PGPJMFPAKOO)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, GBHFMCEHNPG> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x5796430", Offset = "0x5794C30", VA = "0x185796430", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x57965B0", Offset = "0x5794DB0", VA = "0x1857965B0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4B97B30", Offset = "0x4B96330", VA = "0x184B97B30")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x57963F0", Offset = "0x5794BF0", VA = "0x1857963F0")]
		public SerializedMutableOverridableObscuredEnum(bool DANNHOKBAIC, TObsEnum OPMIAMEJKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5796180", Offset = "0x5794980", VA = "0x185796180", Slot = "18")]
		public sealed override GBHFMCEHNPG FBPKLAMOAFK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5796270", Offset = "0x5794A70", VA = "0x185796270", Slot = "19")]
		public sealed override void JGBIHFFKAGJ(GBHFMCEHNPG GKMGIBMAGHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x57960A0", Offset = "0x57948A0", VA = "0x1857960A0", Slot = "20")]
		public sealed override void BFBBKBDJING(byte[] BEJAFFBKKHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5796370", Offset = "0x5794B70", VA = "0x185796370", Slot = "17")]
		public sealed override void OMPDHJNPJPG()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, LKMFJHBEEMH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7AEAF80", Offset = "0x7AE9780", VA = "0x187AEAF80", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7AEAFC0", Offset = "0x7AE97C0", VA = "0x187AEAFC0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7AEAEE0", Offset = "0x7AE96E0", VA = "0x187AEAEE0")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7AEAE80", Offset = "0x7AE9680", VA = "0x187AEAE80")]
		public MutableOverridableListObscuredString(bool DANNHOKBAIC, List<ObscuredString> OPMIAMEJKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7AEADE0", Offset = "0x7AE95E0", VA = "0x187AEADE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7AEAD50", Offset = "0x7AE9550", VA = "0x187AEAD50", Slot = "17")]
		public override void OMPDHJNPJPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7AEA730", Offset = "0x7AE8F30", VA = "0x187AEA730", Slot = "20")]
		public override void BFBBKBDJING(byte[] BEJAFFBKKHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7AEA9E0", Offset = "0x7AE91E0", VA = "0x187AEA9E0", Slot = "19")]
		public override void JGBIHFFKAGJ(LKMFJHBEEMH GKMGIBMAGHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7AEA800", Offset = "0x7AE9000", VA = "0x187AEA800", Slot = "18")]
		public override LKMFJHBEEMH FBPKLAMOAFK()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : AJHHJIDEHHJ<Vector3>, PMJJAJFIKEM
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
			[Cpp2IlInjected.Address(RVA = "0xF136D0", Offset = "0xF11ED0", VA = "0x180F136D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7AEBEE0", Offset = "0x7AEA6E0", VA = "0x187AEBEE0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x4FBE800", Offset = "0x4FBD000", VA = "0x184FBE800", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x54272E0", Offset = "0x5425AE0", VA = "0x1854272E0")]
		public OverridableVector3(Vector3 OPMIAMEJKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5AB5A90", Offset = "0x5AB4290", VA = "0x185AB5A90")]
		public OverridableVector3(bool DANNHOKBAIC, Vector3 OPMIAMEJKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7AEBE40", Offset = "0x7AEA640", VA = "0x187AEBE40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7AEBE20", Offset = "0x7AEA620", VA = "0x187AEBE20")]
		public static OverridableVector3 FGIKKMMHFBO(Vector3 DDLBJHGGANE)
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
