using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using Cpp2IlInjected;
using Google.Protobuf;
using JetBrains.Annotations;
using RecRoom.Protobuf;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Utils.OverridableFields
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public interface ALUVKUVLWPL
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface HBQYZXIGWOC<a> : ALUVKUVLWPL
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		a Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface JAIIJMZUKHC<a> : HBQYZXIGWOC<a>, ALUVKUVLWPL
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		new bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		new a Value
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
	public interface EQJRLLMQJRH<a> : JAIIJMZUKHC<a>, HBQYZXIGWOC<a>, ALUVKUVLWPL
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class HWSTQHGNAEX
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x81897C0", Offset = "0x81883C0", VA = "0x1881897C0")]
		public static float? RHTCBIGUQPJ(this OverridableFloat a)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableInt : HBQYZXIGWOC<int>, ALUVKUVLWPL
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
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xDB38F0", Offset = "0xDB24F0", VA = "0x180DB38F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x818AFB0", Offset = "0x8189BB0", VA = "0x18818AFB0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2DEBBC0", Offset = "0x2DEA7C0", VA = "0x182DEBBC0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x818AF30", Offset = "0x8189B30", VA = "0x18818AF30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct OverridableFloat : HBQYZXIGWOC<float>, ALUVKUVLWPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private float value;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xDB38F0", Offset = "0xDB24F0", VA = "0x180DB38F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x818AF00", Offset = "0x8189B00", VA = "0x18818AF00", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public float Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x2B5BED0", Offset = "0x2B5AAD0", VA = "0x182B5BED0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x818AE80", Offset = "0x8189A80", VA = "0x18818AE80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct OverridableString : HBQYZXIGWOC<string>, ALUVKUVLWPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private string value;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xDB38F0", Offset = "0xDB24F0", VA = "0x180DB38F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xC3E6B0", Offset = "0xC3D2B0", VA = "0x180C3E6B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xC3E6B0", Offset = "0xC3D2B0", VA = "0x180C3E6B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x818AFE0", Offset = "0x8189BE0", VA = "0x18818AFE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public abstract class ZZKBLMHAVFC<a, b, c> : JAIIJMZUKHC<b>, HBQYZXIGWOC<b>, ALUVKUVLWPL where a : ZZKBLMHAVFC<a, b, c> where c : IMessage<c>
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public abstract bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public abstract b Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2AC32A0", Offset = "0x2AC1EA0", VA = "0x182AC32A0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3EAEE00", Offset = "0x3EADA00", VA = "0x183EAEE00")]
		public ZZKBLMHAVFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3EAEEA0", Offset = "0x3EADAA0", VA = "0x183EAEEA0")]
		public ZZKBLMHAVFC(bool a, [NotNull] b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3EAE7F0", Offset = "0x3EAD3F0", VA = "0x183EAE7F0", Slot = "15")]
		public void FXGYUQVFLAU(HBQYZXIGWOC<b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3EAE510", Offset = "0x3EAD110", VA = "0x183EAE510", Slot = "16")]
		public void Copy(HBQYZXIGWOC<b> other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3EAEC00", Offset = "0x3EAD800", VA = "0x183EAEC00", Slot = "17")]
		public virtual void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract c NGBPCVGWIKV();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void RUMNPCHDVYN(c a);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void UQNJUJEQECM(byte[] a);
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class SerializedMutableOverridableBase<T, InnerType, ProtobufType> : ZZKBLMHAVFC<T, InnerType, ProtobufType> where T : ZZKBLMHAVFC<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private InnerType value;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xAE9750", Offset = "0xAE8350", VA = "0x180AE9750", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xAFCD80", Offset = "0xAFB980", VA = "0x180AFCD80", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xC887C0", Offset = "0xC873C0", VA = "0x180C887C0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5D512F0", Offset = "0x5D4FEF0", VA = "0x185D512F0")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5D51470", Offset = "0x5D50070", VA = "0x185D51470")]
		public SerializedMutableOverridableBase(bool overrides, InnerType value)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, ZPQIKXWNJLX>
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x818ADB0", Offset = "0x81899B0", VA = "0x18818ADB0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x818AE10", Offset = "0x8189A10", VA = "0x18818AE10")]
		public MutableOverridableObscuredInt(bool overrides, ObscuredInt value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x818AC10", Offset = "0x8189810", VA = "0x18818AC10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x818ACD0", Offset = "0x81898D0", VA = "0x18818ACD0", Slot = "20")]
		public override void UQNJUJEQECM(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x818AB60", Offset = "0x8189760", VA = "0x18818AB60", Slot = "19")]
		public override void RUMNPCHDVYN(ZPQIKXWNJLX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x818AA80", Offset = "0x8189680", VA = "0x18818AA80", Slot = "18")]
		public override ZPQIKXWNJLX NGBPCVGWIKV()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, HAFUMHZJIPM>
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x818A9B0", Offset = "0x81895B0", VA = "0x18818A9B0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x818AA10", Offset = "0x8189610", VA = "0x18818AA10")]
		public MutableOverridableObscuredFloat(bool overrides, ObscuredFloat value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x818A800", Offset = "0x8189400", VA = "0x18818A800", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x818A8D0", Offset = "0x81894D0", VA = "0x18818A8D0", Slot = "20")]
		public override void UQNJUJEQECM(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x818A740", Offset = "0x8189340", VA = "0x18818A740", Slot = "19")]
		public override void RUMNPCHDVYN(HAFUMHZJIPM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x818A650", Offset = "0x8189250", VA = "0x18818A650", Slot = "18")]
		public override HAFUMHZJIPM NGBPCVGWIKV()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, DXPYSTHCQAI>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x81898A0", Offset = "0x81884A0", VA = "0x1881898A0")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x818A5E0", Offset = "0x81891E0", VA = "0x18818A5E0")]
		public MutableOverridableObscuredBool(bool overrides, ObscuredBool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x818A430", Offset = "0x8189030", VA = "0x18818A430", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x818A500", Offset = "0x8189100", VA = "0x18818A500", Slot = "20")]
		public override void UQNJUJEQECM(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x818A370", Offset = "0x8188F70", VA = "0x18818A370", Slot = "19")]
		public override void RUMNPCHDVYN(DXPYSTHCQAI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x818A200", Offset = "0x8188E00", VA = "0x18818A200", Slot = "18")]
		public override DXPYSTHCQAI NGBPCVGWIKV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x818A2E0", Offset = "0x8188EE0", VA = "0x18818A2E0", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, EQJRLLMQJRH<ObscuredBool>, JAIIJMZUKHC<ObscuredBool>, HBQYZXIGWOC<ObscuredBool>, ALUVKUVLWPL
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA988B0", Offset = "0xA974B0", VA = "0x180A988B0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xA98890", Offset = "0xA97490", VA = "0x180A98890", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x81898A0", Offset = "0x81884A0", VA = "0x1881898A0")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8189820", Offset = "0x8188420", VA = "0x188189820")]
		public void FXGYUQVFLAU(MutableOverridableDefaultableObscuredBool a)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, ZPQIKXWNJLX> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x5D51EA0", Offset = "0x5D50AA0", VA = "0x185D51EA0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x5D52120", Offset = "0x5D50D20", VA = "0x185D52120", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5D51E00", Offset = "0x5D50A00", VA = "0x185D51E00")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5D51E80", Offset = "0x5D50A80", VA = "0x185D51E80")]
		public SerializedMutableOverridableObscuredEnum(bool overrides, TObsEnum value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5D51860", Offset = "0x5D50460", VA = "0x185D51860", Slot = "18")]
		public sealed override ZPQIKXWNJLX NGBPCVGWIKV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5D51950", Offset = "0x5D50550", VA = "0x185D51950", Slot = "19")]
		public sealed override void RUMNPCHDVYN(ZPQIKXWNJLX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5D51D20", Offset = "0x5D50920", VA = "0x185D51D20", Slot = "20")]
		public sealed override void UQNJUJEQECM(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5D51BD0", Offset = "0x5D507D0", VA = "0x185D51BD0", Slot = "17")]
		public sealed override void Reset()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, MKXVWAWFNCR>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x818A130", Offset = "0x8188D30", VA = "0x18818A130", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x818A170", Offset = "0x8188D70", VA = "0x18818A170", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x818A0A0", Offset = "0x8188CA0", VA = "0x18818A0A0")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x818A040", Offset = "0x8188C40", VA = "0x18818A040")]
		public MutableOverridableListObscuredString(bool overrides, List<ObscuredString> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8189ED0", Offset = "0x8188AD0", VA = "0x188189ED0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8189E40", Offset = "0x8188A40", VA = "0x188189E40", Slot = "17")]
		public override void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8189F60", Offset = "0x8188B60", VA = "0x188189F60", Slot = "20")]
		public override void UQNJUJEQECM(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8189AF0", Offset = "0x81886F0", VA = "0x188189AF0", Slot = "19")]
		public override void RUMNPCHDVYN(MKXVWAWFNCR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8189910", Offset = "0x8188510", VA = "0x188189910", Slot = "18")]
		public override MKXVWAWFNCR NGBPCVGWIKV()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct OverridableVector3 : HBQYZXIGWOC<Vector3>, ALUVKUVLWPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		private Vector3 value;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xDB38F0", Offset = "0xDB24F0", VA = "0x180DB38F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x818B0E0", Offset = "0x8189CE0", VA = "0x18818B0E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAF2FD0", Offset = "0xAF1BD0", VA = "0x180AF2FD0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x58AEBE0", Offset = "0x58AD7E0", VA = "0x1858AEBE0")]
		public OverridableVector3(Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x624E850", Offset = "0x624D450", VA = "0x18624E850")]
		public OverridableVector3(bool overrides, Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x818B040", Offset = "0x8189C40", VA = "0x18818B040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x818B130", Offset = "0x8189D30", VA = "0x18818B130")]
		public static implicit operator OverridableVector3(Vector3 val)
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
