using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.Attributes;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6B7F2E0", Offset = "0x6B7DCE0", VA = "0x186B7F2E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AEC90", Offset = "0x8AD690", VA = "0x1808AEC90")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8AECD0", Offset = "0x8AD6D0", VA = "0x1808AECD0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ABOCBPPPJJF : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x16FBD20", Offset = "0x16FA720", VA = "0x1816FBD20")]
	public ABOCBPPPJJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, OJGAMMOCGJN, IINDNAJKJOB, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x885AE0", Offset = "0x8844E0", VA = "0x180885AE0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8869A0", Offset = "0x8853A0", VA = "0x1808869A0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x885AF0", Offset = "0x8844F0", VA = "0x180885AF0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA34E90", Offset = "0xA33890", VA = "0x180A34E90", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash KCGNLENMMHH);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x903700", Offset = "0x902100", VA = "0x180903700")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[ReadOnlyField]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[SerializeField]
	[HideInInspector]
	[ReadOnlyField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6B804E0", Offset = "0x6B7EEE0", VA = "0x186B804E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6B804A0", Offset = "0x6B7EEA0", VA = "0x186B804A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6B80520", Offset = "0x6B7EF20", VA = "0x186B80520")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6B806D0", Offset = "0x6B7F0D0", VA = "0x186B806D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6B80640", Offset = "0x6B7F040", VA = "0x186B80640")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x91E840", Offset = "0x91D240", VA = "0x18091E840")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA35360", Offset = "0xA33D60", VA = "0x180A35360")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6B80460", Offset = "0x6B7EE60", VA = "0x186B80460")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6B805B0", Offset = "0x6B7EFB0", VA = "0x186B805B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6B7FED0", Offset = "0x6B7E8D0", VA = "0x186B7FED0")]
	public void CopyBounds(SavedExtents AIPFCMFLDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6B803B0", Offset = "0x6B7EDB0", VA = "0x186B803B0")]
	public void SetLocalSpaceBounds(Bounds OGFIMOJAEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xD1D090", Offset = "0xD1BA90", VA = "0x180D1D090")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6B803A0", Offset = "0x6B7EDA0", VA = "0x186B803A0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6B7FF00", Offset = "0x6B7E900", VA = "0x186B7FF00")]
	private void IHMPLNLMEMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6B80180", Offset = "0x6B7EB80", VA = "0x186B80180")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6B7F890", Offset = "0x6B7E290", VA = "0x186B7F890")]
	public static void CalculateLocalBoundsFor(GameObject EABKFLBGOGN, [Out] Bounds OGFIMOJAEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6B800C0", Offset = "0x6B7EAC0", VA = "0x186B800C0")]
	private static void LIELLDKKPIL(Bounds AAMOGMLMOOI, Color FOBCKJHLPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6B803D0", Offset = "0x6B7EDD0", VA = "0x186B803D0")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x88E020", Offset = "0x88CA20", VA = "0x18088E020")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1177E80", Offset = "0x1176880", VA = "0x181177E80")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4B294A0", Offset = "0x4B27EA0", VA = "0x184B294A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "4")]
	public virtual void NDFOPGMFBED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[ABOCBPPPJJF]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4B28FD0", Offset = "0x4B279D0", VA = "0x184B28FD0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4B276B0", Offset = "0x4B260B0", VA = "0x184B276B0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4B29390", Offset = "0x4B27D90", VA = "0x184B29390")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class FLOHLMDPGFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public FLOHLMDPGFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3D5C170", Offset = "0x3D5AB70", VA = "0x183D5C170")]
		internal int PHCIKOENABA(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[ABOCBPPPJJF]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x39B6B10", Offset = "0x39B5510", VA = "0x1839B6B10", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x39B6B70", Offset = "0x39B5570", VA = "0x1839B6B70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x39B69E0", Offset = "0x39B53E0", VA = "0x1839B69E0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey JODEIIFHAPK]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x39B6AA0", Offset = "0x39B54A0", VA = "0x1839B6AA0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x39B6880", Offset = "0x39B5280", VA = "0x1839B6880", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x39B6520", Offset = "0x39B4F20", VA = "0x1839B6520", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x39B58E0", Offset = "0x39B42E0", VA = "0x1839B58E0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x39B57A0", Offset = "0x39B41A0", VA = "0x1839B57A0", Slot = "14")]
	protected virtual string DNMIDFDMCLI(TKeyVal HOODFIDELNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x39B5740", Offset = "0x39B4140", VA = "0x1839B5740", Slot = "4")]
	public bool ContainsKey(TKey JODEIIFHAPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x39B66F0", Offset = "0x39B50F0", VA = "0x1839B66F0", Slot = "5")]
	public bool TryGetValue(TKey JODEIIFHAPK, [Out] TVal CLMKDBDPNNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x39B5830", Offset = "0x39B4230", VA = "0x1839B5830", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x39B5830", Offset = "0x39B4230", VA = "0x1839B5830", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x39B6750", Offset = "0x39B5150", VA = "0x1839B6750")]
	protected EditableSerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class SerializedReferenceKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[SerializeReference]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x882790", Offset = "0x881190", VA = "0x180882790")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x885AE0", Offset = "0x8844E0", VA = "0x180885AE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	protected SerializedReferenceKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class SerializedReferenceDictionary<TKey, TVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private class SerializedReferenceKeyValuePair : SerializedReferenceKeyVal<TKey, TVal>
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3D18EE0", Offset = "0x3D178E0", VA = "0x183D18EE0")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[ABOCBPPPJJF]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4B2A700", Offset = "0x4B29100", VA = "0x184B2A700", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4B29C80", Offset = "0x4B28680", VA = "0x184B29C80", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4B29390", Offset = "0x4B27D90", VA = "0x184B29390")]
	protected SerializedReferenceDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class KKHHIBLOHJJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private class FBNKFOIDMLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public float OFBIGCCMOGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T GJBIHCLEEHA;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public FBNKFOIDMLB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class LLJDCDOFCKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public LLJDCDOFCKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4439CC0", Offset = "0x44386C0", VA = "0x184439CC0")]
		internal bool HFGKBLOBBLE(FBNKFOIDMLB sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly float CHHDMFKJJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly float JODADADJHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private List<FBNKFOIDMLB> BEDOOBACEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private OKEINIHAKEB<FBNKFOIDMLB> DCKDOBDOKMK;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int BNDLCOMOPMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4381D70", Offset = "0x4380770", VA = "0x184381D70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4382BE0", Offset = "0x43815E0", VA = "0x184382BE0")]
	public KKHHIBLOHJJ(float AGHLHKJIBIM, float JEJGDLOFPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4382810", Offset = "0x4381210", VA = "0x184382810")]
	public bool OPHLLIICCCE(float MNHDOCAHHMO, T CLMKDBDPNNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x43820D0", Offset = "0x4380AD0", VA = "0x1843820D0")]
	public IEnumerable<T> JNEKMDIFEFE(float MNHDOCAHHMO, [Optional] float? AHBEOJBKGNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4382010", Offset = "0x4380A10", VA = "0x184382010")]
	public void IMAFILHGCCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4381E50", Offset = "0x4380850", VA = "0x184381E50")]
	private void IEKDHBDAJOD(float MNHDOCAHHMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class ABMCOBAJBND<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct NDDGLEBBPHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public T GJBIHCLEEHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public float FFHDLOAHFIK;
	}

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static float HAFPJPPPGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private List<T> HFKJIFGGOMF;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private const int NLAPKJPPANF = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private NDDGLEBBPHL[] FNCIFDCGDBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int HAOLJOAAKMP;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float MFJDHJHAHEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xB33770", Offset = "0xB32170", VA = "0x180B33770")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xB645E0", Offset = "0xB62FE0", VA = "0x180B645E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3DC1000", Offset = "0x3DBFA00", VA = "0x183DC1000")]
	public ABMCOBAJBND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3DC1040", Offset = "0x3DBFA40", VA = "0x183DC1040")]
	public ABMCOBAJBND(int MPLHLKNKHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3DC0320", Offset = "0x3DBED20", VA = "0x183DC0320")]
	public void EGHPKMGPEOO(float MNHDOCAHHMO, T CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3DC0EC0", Offset = "0x3DBF8C0", VA = "0x183DC0EC0")]
	public void IMAFILHGCCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3DC08A0", Offset = "0x3DBF2A0", VA = "0x183DC08A0")]
	public bool HCALJBEPCOJ(float HLDGEKPMJKO, float JDNBCCHOLNP, [Out] T CLMKDBDPNNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3DC0100", Offset = "0x3DBEB00", VA = "0x183DC0100")]
	public bool CAEGOCJECNI(float HLDGEKPMJKO, float JDNBCCHOLNP, [Out] T CLMKDBDPNNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3DC06F0", Offset = "0x3DBF0F0", VA = "0x183DC06F0")]
	public void GAIFEJFGFIH(float HLDGEKPMJKO, float JDNBCCHOLNP, List<T> NONPGPMAOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3DC0870", Offset = "0x3DBF270", VA = "0x183DC0870")]
	private int GHEALNEEIAK(int HBOLMJLANAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3DC02D0", Offset = "0x3DBECD0", VA = "0x183DC02D0")]
	private void DAHCPEFGCJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T IPMNPBHBFJK();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T FMENFDJFDDE(T CLMKDBDPNNH, float LJDCGGEFKLJ);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T JGBOIKKOIHL(T CGCFANNHAMA, T GEGAHIEHOAB);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T BNLDEALEKKA(T CGCFANNHAMA, T GEGAHIEHOAB);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class FBJJCEDCEDA : ABMCOBAJBND<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x893E00", Offset = "0x892800", VA = "0x180893E00", Slot = "4")]
	protected override Vector3 IPMNPBHBFJK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6B7DA10", Offset = "0x6B7C410", VA = "0x186B7DA10", Slot = "5")]
	protected override Vector3 FMENFDJFDDE(Vector3 CLMKDBDPNNH, float LJDCGGEFKLJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6B7DA50", Offset = "0x6B7C450", VA = "0x186B7DA50", Slot = "6")]
	protected override Vector3 JGBOIKKOIHL(Vector3 CGCFANNHAMA, Vector3 GEGAHIEHOAB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6B7D990", Offset = "0x6B7C390", VA = "0x186B7D990", Slot = "7")]
	protected override Vector3 BNLDEALEKKA(Vector3 CGCFANNHAMA, Vector3 GEGAHIEHOAB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6B7DAA0", Offset = "0x6B7C4A0", VA = "0x186B7DAA0")]
	public FBJJCEDCEDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class PPGBGAKLBCH
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2E536D0", Offset = "0x2E520D0", VA = "0x182E536D0")]
	public static PBBHKEHOECG<T1, T2> IFAFEFDLIPC<T1, T2>(T1 ONEOLDGLCKO, T2 AMLJACPCNOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2E53770", Offset = "0x2E52170", VA = "0x182E53770")]
	public static IHBJLOEEHEM<T1, T2, T3> IFAFEFDLIPC<T1, T2, T3>(T1 ONEOLDGLCKO, T2 AMLJACPCNOL, T3 CCNIOMDHEMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x46802C0", Offset = "0x467ECC0", VA = "0x1846802C0")]
	internal static int DBDIFAAGGHG(int OBIELMBKPHH, int OFAGIJGMCHI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5F26DF0", Offset = "0x5F257F0", VA = "0x185F26DF0")]
	internal static int DBDIFAAGGHG(int OBIELMBKPHH, int OFAGIJGMCHI, int IPINPAKBEOB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class PBBHKEHOECG<T1, T2> : IComparable<PBBHKEHOECG<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly T1 ALBFHCEEDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly T2 KHPMMCOMODI;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4907610", Offset = "0x4906010", VA = "0x184907610")]
	public PBBHKEHOECG(T1 ONEOLDGLCKO, T2 AMLJACPCNOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4905B10", Offset = "0x4904510", VA = "0x184905B10", Slot = "4")]
	public int CompareTo(PBBHKEHOECG<T1, T2> AIPFCMFLDKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4905FB0", Offset = "0x49049B0", VA = "0x184905FB0", Slot = "0")]
	public override bool Equals(object AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4906A00", Offset = "0x4905400", VA = "0x184906A00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4906EC0", Offset = "0x49058C0", VA = "0x184906EC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class IHBJLOEEHEM<T1, T2, T3> : IComparable<IHBJLOEEHEM<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly T1 ALBFHCEEDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly T2 KHPMMCOMODI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly T3 EFIIFKKAKIH;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x400DF20", Offset = "0x400C920", VA = "0x18400DF20")]
	public IHBJLOEEHEM(T1 ONEOLDGLCKO, T2 AMLJACPCNOL, T3 CCNIOMDHEMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x400D700", Offset = "0x400C100", VA = "0x18400D700", Slot = "4")]
	public int CompareTo(IHBJLOEEHEM<T1, T2, T3> AIPFCMFLDKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x400D860", Offset = "0x400C260", VA = "0x18400D860", Slot = "0")]
	public override bool Equals(object AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x400DBB0", Offset = "0x400C5B0", VA = "0x18400DBB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x400DD60", Offset = "0x400C760", VA = "0x18400DD60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public T GJBIHCLEEHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x23F4370", Offset = "0x23F2D70", VA = "0x1823F4370")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x23F41E0", Offset = "0x23F2BE0", VA = "0x1823F41E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float FIAJGNEGPMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x923000", Offset = "0x921A00", VA = "0x180923000")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4D8F720", Offset = "0x4D8E120", VA = "0x184D8F720")]
	public T LAEEHEKADDN(float LJDCGGEFKLJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4D8F580", Offset = "0x4D8DF80", VA = "0x184D8F580")]
	public T CJKAIMMOHIK(float LJDCGGEFKLJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T HMDNAJGEDEO(T CGCFANNHAMA, T GEGAHIEHOAB, float LJDCGGEFKLJ);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6B7DB00", Offset = "0x6B7C500", VA = "0x186B7DB00", Slot = "4")]
	protected override float HMDNAJGEDEO(float CGCFANNHAMA, float GEGAHIEHOAB, float LJDCGGEFKLJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6B7DB40", Offset = "0x6B7C540", VA = "0x186B7DB40")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x100E3F0", Offset = "0x100CDF0", VA = "0x18100E3F0", Slot = "4")]
	protected override Vector3 HMDNAJGEDEO(Vector3 CGCFANNHAMA, Vector3 GEGAHIEHOAB, float LJDCGGEFKLJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6B814A0", Offset = "0x6B7FEA0", VA = "0x186B814A0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6B7CD20", Offset = "0x6B7B720", VA = "0x186B7CD20", Slot = "4")]
	protected override Color HMDNAJGEDEO(Color CGCFANNHAMA, Color GEGAHIEHOAB, float LJDCGGEFKLJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6B7CDE0", Offset = "0x6B7B7E0", VA = "0x186B7CDE0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class IPABGINBPEO : EGLGLJGJFJK<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6B7EDB0", Offset = "0x6B7D7B0", VA = "0x186B7EDB0")]
	public IPABGINBPEO(int HBMOJAPOCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6B7ED40", Offset = "0x6B7D740", VA = "0x186B7ED40", Slot = "6")]
	protected override uint IJHDLEICCCN(uint KCGNLENMMHH, string CLMKDBDPNNH)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class DIOJIDJMIKG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly IDisposable LPENGNKGBMO;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public DIOJIDJMIKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct CLEDIBMHMHG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> ECNBONHHHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int MKKMJLCBKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int PKPCKLHBDBO;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4209540", Offset = "0x4207F40", VA = "0x184209540")]
	private CLEDIBMHMHG(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> JBNEKHDEJJK, int JJIIGEHIFHO, int PDAJMLJLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x551D890", Offset = "0x551C290", VA = "0x18551D890")]
	public static CLEDIBMHMHG<T> MMKGNMBHOIH()
	{
		return default(CLEDIBMHMHG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x551E860", Offset = "0x551D260", VA = "0x18551E860")]
	public (int, int, Task<T>) PBBDBKMJCDH(int NCGCLGONMJP, [Optional] CancellationToken OGJIGALEPCA, double CCMOFMGPDOB = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x551D0B0", Offset = "0x551BAB0", VA = "0x18551D0B0")]
	public void CJEFGCDFNHG(int NCGCLGONMJP, int PDAJMLJLHIO, [In] T DFEFBOIIPKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class NGEOMOMCOOC
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6B7EEE0", Offset = "0x6B7D8E0", VA = "0x186B7EEE0")]
	public static CLEDIBMHMHG<IEPJDCHMGFO> MMKGNMBHOIH()
	{
		return default(CLEDIBMHMHG<IEPJDCHMGFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6B7EE60", Offset = "0x6B7D860", VA = "0x186B7EE60")]
	public static void CJEFGCDFNHG([In] this CLEDIBMHMHG<IEPJDCHMGFO> PECHDAFMNOO, int NCGCLGONMJP, int PDAJMLJLHIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public class HCGKFDBNBGF<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly Dictionary<TKey, TVal> IOPFEIFFAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<TVal, TKey> NIKFCEBJBKD;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int FPAPEBLAAHL
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x36CB460", Offset = "0x36C9E60", VA = "0x1836CB460", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool NFLNLAGFBEP
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public ICollection<TKey> IAAGHMCCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3EAAAD0", Offset = "0x3EA94D0", VA = "0x183EAAAD0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public ICollection<TVal> KDBGNFAJJKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3E12B10", Offset = "0x3E11510", VA = "0x183E12B10", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public TVal MJCLDFCFNGD
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3EAAA00", Offset = "0x3EA9400", VA = "0x183EAAA00", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x3EAAB70", Offset = "0x3EA9570", VA = "0x183EAAB70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public TKey MJCLDFCFNGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3EAA000", Offset = "0x3EA8A00", VA = "0x183EAA000")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3EA9CC0", Offset = "0x3EA86C0", VA = "0x183EA9CC0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3EAA7D0", Offset = "0x3EA91D0", VA = "0x183EAA7D0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3EA9BE0", Offset = "0x3EA85E0", VA = "0x183EA9BE0", Slot = "9")]
	public void Add(TKey JODEIIFHAPK, TVal CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3EA9B90", Offset = "0x3EA8590", VA = "0x183EA9B90", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> EDKOAHIAMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3EA9D70", Offset = "0x3EA8770", VA = "0x183EA9D70", Slot = "8")]
	public bool ContainsKey(TKey JODEIIFHAPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3EA9DD0", Offset = "0x3EA87D0", VA = "0x183EA9DD0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> EDKOAHIAMMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3EAA750", Offset = "0x3EA9150", VA = "0x183EAA750", Slot = "10")]
	public bool Remove(TKey JODEIIFHAPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3EAA790", Offset = "0x3EA9190", VA = "0x183EAA790", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> EDKOAHIAMMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3EAA870", Offset = "0x3EA9270", VA = "0x183EAA870", Slot = "11")]
	public bool TryGetValue(TKey JODEIIFHAPK, [Out] TVal CLMKDBDPNNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3EAA060", Offset = "0x3EA8A60", VA = "0x183EAA060", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3EA9E50", Offset = "0x3EA8850", VA = "0x183EA9E50", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] FNCIFDCGDBA, int NPOJHGDDMDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3EA9EE0", Offset = "0x3EA88E0", VA = "0x183EA9EE0")]
	public bool DCBHEAIHJLO(TVal JODEIIFHAPK, [Out] TKey CLMKDBDPNNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3EAA430", Offset = "0x3EA8E30", VA = "0x183EAA430")]
	private void HIPDMDFKLHM(TKey JODEIIFHAPK, TVal APKMEEHDCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3EAA530", Offset = "0x3EA8F30", VA = "0x183EAA530")]
	private void PPBOFLOLLII(TKey JODEIIFHAPK, TVal APKMEEHDCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3EAA100", Offset = "0x3EA8B00", VA = "0x183EAA100")]
	private bool HEEACJBHFNF(TKey JODEIIFHAPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3EAA8D0", Offset = "0x3EA92D0", VA = "0x183EAA8D0")]
	public HCGKFDBNBGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class ELFOHDAICDN<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private ELFOHDAICDN<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x3A00850", Offset = "0x39FF250", VA = "0x183A00850", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x3A0E250", Offset = "0x3A0CC50", VA = "0x183A0E250", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3A0F140", Offset = "0x3A0DB40", VA = "0x183A0F140")]
		public Enumerator(ELFOHDAICDN<T> NONPGPMAOEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3A0D0C0", Offset = "0x3A0BAC0", VA = "0x183A0D0C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3A0DAC0", Offset = "0x3A0C4C0", VA = "0x183A0DAC0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3A0C3D0", Offset = "0x3A0ADD0", VA = "0x183A0C3D0")]
		private void FBJMMHCECGC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private T[] DOJFLIMJFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int GLCOHEPGOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private int CKFONDGBMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private int DHAIIPINBBD;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int FPAPEBLAAHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x39A3840", Offset = "0x39A2240", VA = "0x1839A3840")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public T MJCLDFCFNGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x39A2F80", Offset = "0x39A1980", VA = "0x1839A2F80")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x39A3B00", Offset = "0x39A2500", VA = "0x1839A3B00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x39A5080", Offset = "0x39A3A80", VA = "0x1839A5080")]
	public ELFOHDAICDN(int HBMOJAPOCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x39A33F0", Offset = "0x39A1DF0", VA = "0x1839A33F0")]
	public void EGHPKMGPEOO(T LJDCGGEFKLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x39A3880", Offset = "0x39A2280", VA = "0x1839A3880")]
	public void IMAFILHGCCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x39A4CB0", Offset = "0x39A36B0", VA = "0x1839A4CB0")]
	public void NOEEHILPPAN(int KFBJHPBJLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x39A46B0", Offset = "0x39A30B0", VA = "0x1839A46B0")]
	public void LNEHFAGGEJB(T[] FNCIFDCGDBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x39A2E10", Offset = "0x39A1810", VA = "0x1839A2E10")]
	public Enumerator BPGPEIEKEPK()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x39A4D90", Offset = "0x39A3790", VA = "0x1839A4D90", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x39A4D90", Offset = "0x39A3790", VA = "0x1839A4D90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x39A4130", Offset = "0x39A2B30", VA = "0x1839A4130")]
	private int KENBCPLGKAP(int EBDDHAPIAHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x39A2D70", Offset = "0x39A1770", VA = "0x1839A2D70")]
	private int ABNNIHNFGDJ(int EBDDHAPIAHH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class CHNHCNFMMGJ<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate Task<TResult> JDCPBLMLIAF(TRequest IHHJPAMNDBP, CancellationToken OGJIGALEPCA);

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public enum CCNHMMAEHAA
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class MKDKHPAOJOC
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private const float BLOILPNDHPG = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TimeSpan PNNCMINGLDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int IKNFKONKFIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CCNHMMAEHAA NKNLAGHPEMC;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public static readonly MKDKHPAOJOC LGKHJAOMEPI;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float HIBHONKKLJH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x4625C60", Offset = "0x4624660", VA = "0x184625C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan EHJBMNDGPOF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x4625DB0", Offset = "0x46247B0", VA = "0x184625DB0")]
		public MKDKHPAOJOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private readonly struct FIALHBBGJLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly TRequest IHHJPAMNDBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly CancellationToken OGJIGALEPCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly TaskCompletionSource<TResult> MGJCJEDJLDK;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3D4CB70", Offset = "0x3D4B570", VA = "0x183D4CB70")]
		public FIALHBBGJLI(TRequest IHHJPAMNDBP, TaskCompletionSource<TResult> MGJCJEDJLDK, CancellationToken OGJIGALEPCA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct BADALMOKMFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public CHNHCNFMMGJ<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x4F392D0", Offset = "0x4F37CD0", VA = "0x184F392D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x4F39FC0", Offset = "0x4F389C0", VA = "0x184F39FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct MFDJJMALABP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CHNHCNFMMGJ<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private FIALHBBGJLI <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x460FA00", Offset = "0x460E400", VA = "0x18460FA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4610CA0", Offset = "0x460F6A0", VA = "0x184610CA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly CancellationTokenSource FKELCJBFAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<FIALHBBGJLI> HNKHIKBIDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly MKDKHPAOJOC BBAJBCGPDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly JDCPBLMLIAF GMABKAHEGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Task FLDPCCKCDAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int CIDBLNEKNID;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x543BEA0", Offset = "0x543A8A0", VA = "0x18543BEA0")]
	public CHNHCNFMMGJ(JDCPBLMLIAF GMABKAHEGED, [Optional] MKDKHPAOJOC BBAJBCGPDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x543B940", Offset = "0x543A340", VA = "0x18543B940")]
	public Task<TResult> PFDLAOAMGDP(TRequest IHHJPAMNDBP, CancellationToken OGJIGALEPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x543A1E0", Offset = "0x5438BE0", VA = "0x18543A1E0")]
	private void AAGFNPEBMDB(FIALHBBGJLI OAMBILBDOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x543A5D0", Offset = "0x5438FD0", VA = "0x18543A5D0")]
	[AsyncStateMachine(typeof(CHNHCNFMMGJ<, >.BADALMOKMFF))]
	private Task EMEAGMKHLAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x543B180", Offset = "0x5439B80", VA = "0x18543B180")]
	private FIALHBBGJLI MPDBFPKOKIK()
	{
		return default(FIALHBBGJLI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x543A2B0", Offset = "0x5438CB0", VA = "0x18543A2B0")]
	[AsyncStateMachine(typeof(CHNHCNFMMGJ<, >.MFDJJMALABP))]
	private Task CBPCDIPGBDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x543A950", Offset = "0x5439350", VA = "0x18543A950")]
	private void JENFJPNJBKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x543A590", Offset = "0x5438F90", VA = "0x18543A590", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class OFGACLPJNJI<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly List<T> JNHGBAGBHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private HashSet<T> NPHMPPGIFJM;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int FPAPEBLAAHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x36CB460", Offset = "0x36C9E60", VA = "0x1836CB460", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool NFLNLAGFBEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T MJCLDFCFNGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3C20", Offset = "0x2BC2620", VA = "0x182BC3C20", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x4826200", Offset = "0x4824C00", VA = "0x184826200", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3D8D5A0", Offset = "0x3D8BFA0", VA = "0x183D8D5A0", Slot = "11")]
	public void Add(T EDKOAHIAMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4825900", Offset = "0x4824300", VA = "0x184825900")]
	public bool KPMONNEGAGF(T EDKOAHIAMMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x4825EB0", Offset = "0x48248B0", VA = "0x184825EB0", Slot = "15")]
	public bool Remove(T EDKOAHIAMMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x39A7040", Offset = "0x39A5A40", VA = "0x1839A7040", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3D285D0", Offset = "0x3D26FD0", VA = "0x183D285D0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x48254F0", Offset = "0x4823EF0", VA = "0x1848254F0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x48255A0", Offset = "0x4823FA0", VA = "0x1848255A0", Slot = "13")]
	public bool Contains(T EDKOAHIAMMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4825600", Offset = "0x4824000", VA = "0x184825600", Slot = "14")]
	public void CopyTo(T[] FNCIFDCGDBA, int NPOJHGDDMDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x43D3FD0", Offset = "0x43D29D0", VA = "0x1843D3FD0", Slot = "6")]
	public int IndexOf(T EDKOAHIAMMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x48257B0", Offset = "0x48241B0", VA = "0x1848257B0", Slot = "7")]
	public void Insert(int EBDDHAPIAHH, T EDKOAHIAMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4825B20", Offset = "0x4824520", VA = "0x184825B20", Slot = "8")]
	public void RemoveAt(int EBDDHAPIAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4825F80", Offset = "0x4824980", VA = "0x184825F80")]
	public OFGACLPJNJI()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x22A6720", Offset = "0x22A5120", VA = "0x1822A6720")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6B80A70", Offset = "0x6B7F470", VA = "0x186B80A70")]
		public SerializedGuid([In] Guid HLIKNGLOMIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6B80860", Offset = "0x6B7F260", VA = "0x186B80860")]
		public static SerializedGuid FJHOAKGAJHJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6B808F0", Offset = "0x6B7F2F0", VA = "0x186B808F0")]
		public static SerializedGuid IPKEOIOIOJA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6B80960", Offset = "0x6B7F360", VA = "0x186B80960")]
		public bool OFKDLHJCMKP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6B80A40", Offset = "0x6B7F440", VA = "0x186B80A40", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6B809C0", Offset = "0x6B7F3C0", VA = "0x186B809C0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6B80790", Offset = "0x6B7F190", VA = "0x186B80790", Slot = "7")]
		public bool Equals(SerializedGuid AIPFCMFLDKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6B807D0", Offset = "0x6B7F1D0", VA = "0x186B807D0", Slot = "0")]
		public override bool Equals(object GIGIFGONEAO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6B808E0", Offset = "0x6B7F2E0", VA = "0x186B808E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6B80760", Offset = "0x6B7F160", VA = "0x186B80760", Slot = "6")]
		public int CompareTo(SerializedGuid AIPFCMFLDKG)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class CKDMMAAJJDA : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly Type CDFBIKOEJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly string NMAIEPHIIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly bool EJKPGKLGLDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly bool NMPALGDLMFO;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6B7BB00", Offset = "0x6B7A500", VA = "0x186B7BB00")]
	public CKDMMAAJJDA(Type OCGJJOKJDIG, string HHDHPMPPLGN, bool JCHMBHJLGEH = false, bool JHPLPJBJOEH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class PFEDKLFBPJA<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public readonly struct BMBLFPAFOMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly long FFCKOJBGKEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly long KPGGGGPFDHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly int FHJEGDEDLPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly int EDFOLBCFJOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public readonly bool LMBAFGIMOLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly string AKCPKACDMGP;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x50685A0", Offset = "0x5066FA0", VA = "0x1850685A0")]
		public BMBLFPAFOMI(long FFCKOJBGKEF, int FHJEGDEDLPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5068570", Offset = "0x5066F70", VA = "0x185068570")]
		public BMBLFPAFOMI(long FFCKOJBGKEF, long KPGGGGPFDHE, int FHJEGDEDLPM, int EDFOLBCFJOL, bool LMBAFGIMOLC, string AKCPKACDMGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5068520", Offset = "0x5066F20", VA = "0x185068520")]
		public int IIGAJLFCGAA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5068400", Offset = "0x5066E00", VA = "0x185068400")]
		public int BPOHNMLLABM(int PKDICBEJIGN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5068420", Offset = "0x5066E20", VA = "0x185068420")]
		public double DKFCMFIODEG()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5068480", Offset = "0x5066E80", VA = "0x185068480")]
		public BMBLFPAFOMI GMCLOJMONKP(long KPGGGGPFDHE, int EDFOLBCFJOL)
		{
			return default(BMBLFPAFOMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class BEABGGDOFCM : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private struct HFFPACNDHHC<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public BEABGGDOFCM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public Func<BEABGGDOFCM, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private BEABGGDOFCM <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x3ED3160", Offset = "0x3ED1B60", VA = "0x183ED3160", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x3ED36B0", Offset = "0x3ED20B0", VA = "0x183ED36B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public readonly TKey JDBNAJHLPPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly PFEDKLFBPJA<TKey> ANDGGAMNIIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public readonly ANDGIEDMMDP AGICKJCJECJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private List<BEABGGDOFCM> AJEMDLBOBJH;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string PLJEDEADBAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x4D383A0", Offset = "0x4D36DA0", VA = "0x184D383A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<BEABGGDOFCM> PCCKPONMFLA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x5002B30", Offset = "0x5001530", VA = "0x185002B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public BMBLFPAFOMI CEEFEPNLHKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x5002B70", Offset = "0x5001570", VA = "0x185002B70")]
			[CompilerGenerated]
			get
			{
				return default(BMBLFPAFOMI);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x50028A0", Offset = "0x50012A0", VA = "0x1850028A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5002B90", Offset = "0x5001590", VA = "0x185002B90")]
		internal BEABGGDOFCM(PFEDKLFBPJA<TKey> ANDGGAMNIIJ, TKey JODEIIFHAPK, ANDGIEDMMDP AGICKJCJECJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x50026E0", Offset = "0x50010E0", VA = "0x1850026E0")]
		public BEABGGDOFCM AANPAODBHAE(TKey JODEIIFHAPK, [Optional] ANDGIEDMMDP? OFDIJBFBCOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2939E30", Offset = "0x2938830", VA = "0x182939E30")]
		[AsyncStateMachine(typeof(HFFPACNDHHC<>))]
		public Task<T> BIGJCGLMAHD<T>(TKey JODEIIFHAPK, Func<BEABGGDOFCM, Task<T>> MIDOKEPAEFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x50028D0", Offset = "0x50012D0", VA = "0x1850028D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class HPHOGANFIDP : IEnumerable<(TKey, List<TKey>, BMBLFPAFOMI)>, IEnumerable, IEnumerator<(TKey, List<TKey>, BMBLFPAFOMI)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private (TKey key, List<TKey> path, BMBLFPAFOMI timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public PFEDKLFBPJA<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private IEnumerator<(TKey key, List<TKey> path, BMBLFPAFOMI timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, BMBLFPAFOMI) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x2292FF0", Offset = "0x22919F0", VA = "0x182292FF0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, BMBLFPAFOMI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x3F03010", Offset = "0x3F01A10", VA = "0x183F03010", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x22930E0", Offset = "0x2291AE0", VA = "0x1822930E0")]
		[DebuggerHidden]
		public HPHOGANFIDP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3BE5520", Offset = "0x3BE3F20", VA = "0x183BE5520", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3F02B30", Offset = "0x3F01530", VA = "0x183F02B30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3F02AE0", Offset = "0x3F014E0", VA = "0x183F02AE0")]
		private void GPKDFCKBEHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3F02FC0", Offset = "0x3F019C0", VA = "0x183F02FC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3F02EE0", Offset = "0x3F018E0", VA = "0x183F02EE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, BMBLFPAFOMI)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3BED960", Offset = "0x3BEC360", VA = "0x183BED960", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class GNIPFKDGOKF : IEnumerable<(TKey, List<TKey>, BMBLFPAFOMI)>, IEnumerable, IEnumerator<(TKey, List<TKey>, BMBLFPAFOMI)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private (TKey key, List<TKey> path, BMBLFPAFOMI timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private BEABGGDOFCM timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public BEABGGDOFCM <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public PFEDKLFBPJA<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private IEnumerator<BEABGGDOFCM> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private IEnumerator<(TKey key, List<TKey> path, BMBLFPAFOMI timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private (TKey, List<TKey>, BMBLFPAFOMI) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x2292FF0", Offset = "0x22919F0", VA = "0x182292FF0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, BMBLFPAFOMI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x3E3CBA0", Offset = "0x3E3B5A0", VA = "0x183E3CBA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x22930E0", Offset = "0x2291AE0", VA = "0x1822930E0")]
		[DebuggerHidden]
		public GNIPFKDGOKF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3E3CC00", Offset = "0x3E3B600", VA = "0x183E3CC00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3E3C1D0", Offset = "0x3E3ABD0", VA = "0x183E3C1D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3E3C170", Offset = "0x3E3AB70", VA = "0x183E3C170")]
		private void GPKDFCKBEHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3E3C9B0", Offset = "0x3E3B3B0", VA = "0x183E3C9B0")]
		private void OLBNGAJNBBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x3E3CB50", Offset = "0x3E3B550", VA = "0x183E3CB50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3E3CA10", Offset = "0x3E3B410", VA = "0x183E3CA10", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, BMBLFPAFOMI)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3E3CB10", Offset = "0x3E3B510", VA = "0x183E3CB10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly Action<TKey, BMBLFPAFOMI, ANDGIEDMMDP> IBEKLLCJEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Action<TKey, BMBLFPAFOMI, ANDGIEDMMDP> HINKHJBAPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Action<PFEDKLFBPJA<TKey>, ANDGIEDMMDP> EKNLAEHICPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly ANDGIEDMMDP AGICKJCJECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly BEABGGDOFCM HKKADHDLBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private bool PJOLCHEBHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int NLBJBNCLLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Stopwatch KBKBMDMDNDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly int NABPCPNCKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private string LNFMGLNGKEL;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public BEABGGDOFCM FNOMMCJLFMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8893E0", Offset = "0x887DE0", VA = "0x1808893E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[NotNull]
	public string PLJEDEADBAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x885FC0", Offset = "0x8849C0", VA = "0x180885FC0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x491C1B0", Offset = "0x491ABB0", VA = "0x18491C1B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x491C210", Offset = "0x491AC10", VA = "0x18491C210")]
	public PFEDKLFBPJA(TKey KKDDLHOJEJE, ANDGIEDMMDP AGICKJCJECJ, [Optional] int? FHJEGDEDLPM, [Optional][CanBeNull] Stopwatch KBKBMDMDNDA, [Optional] Action<TKey, BMBLFPAFOMI, ANDGIEDMMDP> IBEKLLCJEBD, [Optional] Action<TKey, BMBLFPAFOMI, ANDGIEDMMDP> HINKHJBAPEE, [Optional] Action<PFEDKLFBPJA<TKey>, ANDGIEDMMDP> EKNLAEHICPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x491BEB0", Offset = "0x491A8B0", VA = "0x18491BEB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x491C010", Offset = "0x491AA10", VA = "0x18491C010")]
	[IteratorStateMachine(typeof(PFEDKLFBPJA<>.HPHOGANFIDP))]
	public IEnumerable<(TKey, List<TKey>, BMBLFPAFOMI)> JPOHOMDAIJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x491C0C0", Offset = "0x491AAC0", VA = "0x18491C0C0")]
	[IteratorStateMachine(typeof(PFEDKLFBPJA<>.GNIPFKDGOKF))]
	private IEnumerable<(TKey, List<TKey>, BMBLFPAFOMI)> JPOHOMDAIJF(List<TKey> FNGJKHBMPIH, BEABGGDOFCM LABIJIIJIMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x491BF90", Offset = "0x491A990", VA = "0x18491BF90")]
	private (long, int) IHIOFJMGOMA()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public abstract class PEGPBHEFAHP<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut LFNKHEJMFMA(PFEDKLFBPJA<TKey> ANDGGAMNIIJ);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	protected PEGPBHEFAHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public abstract class MKFDNHFOONO<TKey> : PEGPBHEFAHP<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate string AMAPMDPELKL(TKey JODEIIFHAPK);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x4625E20", Offset = "0x4624820", VA = "0x184625E20")]
	private static string DDHFFNHBJBJ(TKey JODEIIFHAPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x4625E60", Offset = "0x4624860", VA = "0x184625E60", Slot = "4")]
	public override string LFNKHEJMFMA(PFEDKLFBPJA<TKey> ANDGGAMNIIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4625F50", Offset = "0x4624950", VA = "0x184625F50")]
	public string LFNKHEJMFMA(PFEDKLFBPJA<TKey> ANDGGAMNIIJ, [NotNull] AMAPMDPELKL PHHIFHDBHGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string LNPHGCNHAIJ(PFEDKLFBPJA<TKey> ANDGGAMNIIJ, [NotNull] AMAPMDPELKL PHHIFHDBHGG);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3D4BCF0", Offset = "0x3D4A6F0", VA = "0x183D4BCF0")]
	protected MKFDNHFOONO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class CIIHIMODNOO<TKey> : PEGPBHEFAHP<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate string FBLELOOEPJN(TKey JODEIIFHAPK);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly string POGIBADCONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly double IGEPFIDIEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly bool LLGGBEDPBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly int AMBFBMOGBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly ISet<string> MNOHAJAAFCK;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x543D400", Offset = "0x543BE00", VA = "0x18543D400")]
	private static string DDHFFNHBJBJ(TKey JODEIIFHAPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x543E040", Offset = "0x543CA40", VA = "0x18543E040")]
	public CIIHIMODNOO(string POGIBADCONG = "F2", double IGEPFIDIEOI = double.MaxValue, bool LLGGBEDPBJH = false, int AMBFBMOGBFM = int.MaxValue, [Optional] ISet<string> MNOHAJAAFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x543D820", Offset = "0x543C220", VA = "0x18543D820", Slot = "4")]
	public override Dictionary<string, string> LFNKHEJMFMA(PFEDKLFBPJA<TKey> ANDGGAMNIIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x543DF60", Offset = "0x543C960", VA = "0x18543DF60")]
	private bool LHJGFMHAGNK(string IJGEOMEMMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x543D910", Offset = "0x543C310", VA = "0x18543D910")]
	public Dictionary<string, string> LFNKHEJMFMA(PFEDKLFBPJA<TKey> ANDGGAMNIIJ, FBLELOOEPJN PHHIFHDBHGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x543D5A0", Offset = "0x543BFA0", VA = "0x18543D5A0")]
	private string IJOINLAGICL(StringBuilder HEECLLBBHMH, List<TKey> EJGGLODKFBD, FBLELOOEPJN PHHIFHDBHGG, bool PDOGCKIOCFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x543D440", Offset = "0x543BE40", VA = "0x18543D440")]
	private static void EIJIKAMAGPC(StringBuilder NOABHENBJGA, string ELDIENKLFKC, bool MHHOMGPOHPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class CGNKOBJOKLH<TKey> : MKFDNHFOONO<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct NMFIDOJJFFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AMAPMDPELKL keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static CGNKOBJOKLH<TKey> LPENGNKGBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly string[] FIMADAMFNNA;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5438570", Offset = "0x5436F70", VA = "0x185438570")]
	private CGNKOBJOKLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x54375D0", Offset = "0x5435FD0", VA = "0x1854375D0", Slot = "5")]
	protected override string LNPHGCNHAIJ(PFEDKLFBPJA<TKey> ANDGGAMNIIJ, AMAPMDPELKL PHHIFHDBHGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x54374C0", Offset = "0x5435EC0", VA = "0x1854374C0")]
	[CompilerGenerated]
	internal static string LLCMCDCNFLJ(string EAHIFHJDOBL, TKey JODEIIFHAPK, NMFIDOJJFFJ P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class EFNLFLMFIHK : PFEDKLFBPJA<string>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class BABOEIMNFAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Action<EFNLFLMFIHK, ANDGIEDMMDP> callback;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public BABOEIMNFAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6B7B910", Offset = "0x6B7A310", VA = "0x186B7B910")]
		internal void LAIEOMJDDGJ(PFEDKLFBPJA<string> timer, ANDGIEDMMDP log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6B7D840", Offset = "0x6B7C240", VA = "0x186B7D840")]
	public EFNLFLMFIHK(ANDGIEDMMDP AGICKJCJECJ, [Optional] string OLICOILHGJN, [Optional] int? FHJEGDEDLPM, [Optional] Stopwatch KBKBMDMDNDA, [Optional] Action<string, BMBLFPAFOMI, ANDGIEDMMDP> IBEKLLCJEBD, [Optional] Action<string, BMBLFPAFOMI, ANDGIEDMMDP> HINKHJBAPEE, [Optional] Action<EFNLFLMFIHK, ANDGIEDMMDP> EKNLAEHICPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6B7D780", Offset = "0x6B7C180", VA = "0x186B7D780")]
	private static Action<PFEDKLFBPJA<string>, ANDGIEDMMDP> OKJKIJEFCPN(Action<EFNLFLMFIHK, ANDGIEDMMDP> DKOPNCNMOIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public abstract class CJDKJFEAENN
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private class GOCBNNAKKED : CJDKJFEAENN
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static CJDKJFEAENN LPENGNKGBMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x6B7EC00", Offset = "0x6B7D600", VA = "0x186B7EC00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override float LPGOPCEMIDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0xB33A90", Offset = "0xB32490", VA = "0x180B33A90", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6B7ECF0", Offset = "0x6B7D6F0", VA = "0x186B7ECF0")]
		public GOCBNNAKKED()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static CJDKJFEAENN FHGBHPJGFKM;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static CJDKJFEAENN LGKHJAOMEPI
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6B7B9A0", Offset = "0x6B7A3A0", VA = "0x186B7B9A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public abstract float LPGOPCEMIDH
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	protected CJDKJFEAENN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface GEOMECACKBK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool DLOJNDBBAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface FGDPIAEELFA<T> : GEOMECACKBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	[NotNull]
	Task<T> CGJICAOBAOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	[NotNull]
	CAPIMDIPLHM<T> PECHBLFLADO
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class ECEAGPEJAEC
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2B1F600", Offset = "0x2B1E000", VA = "0x182B1F600")]
	public static FGDPIAEELFA<TResource> LMLCOHCBMMG<TResource, TId>(this IMDBOMPAFBK<TId, TResource> INKPCFGBNLA, TId KFBALBFDDFF, [Optional] Func<TId, CancellationToken, Task<TResource>>? DDLONLHNPAA) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class PCPCADDKIEO
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private sealed class POCKIPKFHCM<T> : IEFFLHNIJHO<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override Task<T?> CGJICAOBAOM
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override CAPIMDIPLHM<T?> PECHBLFLADO
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x8869A0", Offset = "0x8853A0", VA = "0x1808869A0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x493C4B0", Offset = "0x493AEB0", VA = "0x18493C4B0")]
		public POCKIPKFHCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "10")]
		protected override void CMHPCCIKJGA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private sealed class ALFHNEBNMIE<T> : IEFFLHNIJHO<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly T NADHMEOJNED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly Action<T>? PCMPEGAPKEI;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override Task<T> CGJICAOBAOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x8853C0", VA = "0x1808869C0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override CAPIMDIPLHM<T> PECHBLFLADO
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x8869B0", Offset = "0x8853B0", VA = "0x1808869B0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x3DE6420", Offset = "0x3DE4E20", VA = "0x183DE6420")]
		public ALFHNEBNMIE(T DKMPFGECNCP, Action<T>? EHDJACLPKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x3DE6220", Offset = "0x3DE4C20", VA = "0x183DE6220", Slot = "10")]
		protected override void CMHPCCIKJGA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private sealed class GHHFBMMHILN<T> : IEFFLHNIJHO<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override Task<T> CGJICAOBAOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override CAPIMDIPLHM<T> PECHBLFLADO
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x8869A0", Offset = "0x8853A0", VA = "0x1808869A0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x3E249D0", Offset = "0x3E233D0", VA = "0x183E249D0")]
		public GHHFBMMHILN(Exception DCGMDLPABHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "10")]
		protected override void CMHPCCIKJGA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private sealed class KJEBIBEADEC<T> : IEFFLHNIJHO<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct BGADCLNJKAL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public Task<FGDPIAEELFA<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private TaskAwaiter<FGDPIAEELFA<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x50088B0", Offset = "0x50072B0", VA = "0x1850088B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x5009300", Offset = "0x5007D00", VA = "0x185009300", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private struct DLLEGNPIBEF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public Task<FGDPIAEELFA<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter<FGDPIAEELFA<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x5A75050", Offset = "0x5A73A50", VA = "0x185A75050", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x5A752F0", Offset = "0x5A73CF0", VA = "0x185A752F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly Task<FGDPIAEELFA<T>> CGMMPECDEGJ;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override Task<T> CGJICAOBAOM
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x8869A0", Offset = "0x8853A0", VA = "0x1808869A0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override CAPIMDIPLHM<T> PECHBLFLADO
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x886D60", Offset = "0x885760", VA = "0x180886D60", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x43818A0", Offset = "0x43802A0", VA = "0x1843818A0")]
		public KJEBIBEADEC(Task<FGDPIAEELFA<T>> CCAACFNOONL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x4381330", Offset = "0x437FD30", VA = "0x184381330", Slot = "10")]
		protected override void CMHPCCIKJGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x43813C0", Offset = "0x437FDC0", VA = "0x1843813C0")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(KJEBIBEADEC<>.BGADCLNJKAL))]
		internal static Task<T> FLIHEMPIFEA(Task<FGDPIAEELFA<T>> CCAACFNOONL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x43816C0", Offset = "0x43800C0", VA = "0x1843816C0")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(KJEBIBEADEC<>.DLLEGNPIBEF))]
		internal static Task KAONACHJCHO(Task<FGDPIAEELFA<T>> CCAACFNOONL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class NLGMLHJOBBF<TIn, TOut> : IEFFLHNIJHO<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct NFKMEBPKPPN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public AsyncTaskMethodBuilder<TOut> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public Func<TIn, TOut> transformFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public Task<TIn> innerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private Func<TIn, TOut> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private TaskAwaiter<TIn> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x46ABBE0", Offset = "0x46AA5E0", VA = "0x1846ABBE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x3E2FDD0", Offset = "0x3E2E7D0", VA = "0x183E2FDD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly FGDPIAEELFA<TIn> FIDNCIHKOBF;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<TOut> CGJICAOBAOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x8869A0", Offset = "0x8853A0", VA = "0x1808869A0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override CAPIMDIPLHM<TOut> PECHBLFLADO
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x886D60", Offset = "0x885760", VA = "0x180886D60", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x46C6B20", Offset = "0x46C5520", VA = "0x1846C6B20")]
		public NLGMLHJOBBF(FGDPIAEELFA<TIn> ENLKJOLBLHK, Func<TIn, TOut> MADJANONAOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x46C67B0", Offset = "0x46C51B0", VA = "0x1846C67B0", Slot = "10")]
		protected override void CMHPCCIKJGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x46C6800", Offset = "0x46C5200", VA = "0x1846C6800")]
		[AsyncStateMachine(typeof(NLGMLHJOBBF<, >.NFKMEBPKPPN))]
		[CompilerGenerated]
		internal static Task<TOut> JONPEOBGLKP(Task<TIn> IGJMLHCPMKA, Func<TIn, TOut> MADJANONAOO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2E2E670", Offset = "0x2E2D070", VA = "0x182E2E670")]
	public static FGDPIAEELFA<T> MANEDJLMOBE<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2E2E5C0", Offset = "0x2E2CFC0", VA = "0x182E2E5C0")]
	public static FGDPIAEELFA<T> ICADMPBHNBI<T>(T DFEFBOIIPKP, [Optional] Action<T>? EHDJACLPKIA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2A287D0", Offset = "0x2A271D0", VA = "0x182A287D0")]
	public static FGDPIAEELFA<T> BBBCNCNNKJH<T>(Exception DCGMDLPABHJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x2A287D0", Offset = "0x2A271D0", VA = "0x182A287D0")]
	public static FGDPIAEELFA<T> AMIODBOFBCL<T>(Task<FGDPIAEELFA<T>> CCAACFNOONL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2A101B0", Offset = "0x2A0EBB0", VA = "0x182A101B0")]
	public static FGDPIAEELFA<TOut> DHHBNJAMIOF<TOut, TIn>(FGDPIAEELFA<TIn> OMKGKCDECFC, Func<TIn, TOut> MADJANONAOO) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public abstract class IEFFLHNIJHO<T> : FGDPIAEELFA<T>, GEOMECACKBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly string ALBCHDIEBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly MHHIDICAJHA LKFGKPBNMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private bool PJOLCHEBHAJ;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool DLOJNDBBAAK
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xD03B10", Offset = "0xD02510", VA = "0x180D03B10", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public abstract Task<T> CGJICAOBAOM
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public abstract CAPIMDIPLHM<T> PECHBLFLADO
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x4005920", Offset = "0x4004320", VA = "0x184005920")]
	public IEFFLHNIJHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x4005570", Offset = "0x4003F70", VA = "0x184005570", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void CMHPCCIKJGA();
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class NMIGKGCBFJE<TTask, T> : IEFFLHNIJHO<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class IFBFDEICGEJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public IFBFDEICGEJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x36B8A60", Offset = "0x36B7460", VA = "0x1836B8A60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x36B8FD0", Offset = "0x36B79D0", VA = "0x1836B8FD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public NMIGKGCBFJE<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public IFBFDEICGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x4008570", Offset = "0x4006F70", VA = "0x184008570")]
		[AsyncStateMachine(typeof(NMIGKGCBFJE<, >.IFBFDEICGEJ.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> DBKAGGCKHEC(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly Task<T> CCAACFNOONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	protected readonly CancellationTokenSource HKMLILDBOFE;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public override Task<T> CGJICAOBAOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public override CAPIMDIPLHM<T> PECHBLFLADO
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8869A0", Offset = "0x8853A0", VA = "0x1808869A0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x46C7830", Offset = "0x46C6230", VA = "0x1846C7830")]
	protected NMIGKGCBFJE(TTask CCAACFNOONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x46C77E0", Offset = "0x46C61E0", VA = "0x1846C77E0", Slot = "10")]
	protected override void CMHPCCIKJGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T OGMAHNLOGAJ(TTask HELKEHCFKFA);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void KFMGNINKLBH();
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class PMKNBGBBHJC<T> : IEFFLHNIJHO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly LMGHFFLKBKA<Task<T>> CCEDEJNOAOG;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public override Task<T> CGJICAOBAOM
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x4007A00", Offset = "0x4006400", VA = "0x184007A00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public override CAPIMDIPLHM<T> PECHBLFLADO
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8869A0", Offset = "0x8853A0", VA = "0x1808869A0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x493A740", Offset = "0x4939140", VA = "0x18493A740")]
	public PMKNBGBBHJC(LMGHFFLKBKA<Task<T>> LLENNCHABNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x493A720", Offset = "0x4939120", VA = "0x18493A720", Slot = "10")]
	protected override void CMHPCCIKJGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class DBCICILGODC
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static readonly HashAlgorithmName OAEJEKCGONL;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly ThreadLocal<IncrementalHash> JLMDDMFGLOA;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6B7D550", Offset = "0x6B7BF50", VA = "0x186B7D550")]
	public static int ONDGMBOOCOA(this OJGAMMOCGJN PDEAPAOLGGK, IncrementalHash KCGNLENMMHH, byte[] OAIJDJLEIAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6B7CEB0", Offset = "0x6B7B8B0", VA = "0x186B7CEB0")]
	public static bool EOONECKAOEP([CanBeNull] this OJGAMMOCGJN PDEAPAOLGGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6B7CF10", Offset = "0x6B7B910", VA = "0x186B7CF10")]
	public static bool EOONECKAOEP([CanBeNull] this OJGAMMOCGJN PDEAPAOLGGK, [Out] string DMBOCOKFCJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6B7D220", Offset = "0x6B7BC20", VA = "0x186B7D220")]
	public static bool EOONECKAOEP([CanBeNull] this OJGAMMOCGJN PDEAPAOLGGK, IncrementalHash KCGNLENMMHH, byte[] OAIJDJLEIAK, [Out] string DMBOCOKFCJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6B7CE20", Offset = "0x6B7B820", VA = "0x186B7CE20")]
	private static bool CCCGLOCDAII(byte[] HMBFDAOGBDO, Span<byte> GMJFOMENNHJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class NMOMGIFIKOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6B7EF30", Offset = "0x6B7D930", VA = "0x186B7EF30")]
	public static int KDGAGENJHDJ(HashAlgorithmName KAKGOGANCDG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6B7F080", Offset = "0x6B7DA80", VA = "0x186B7F080")]
	public static int ONDGMBOOCOA(this IINDNAJKJOB OGADBMOLAPP, byte[] BBMPOKDFKHK, IncrementalHash KCGNLENMMHH, byte[] LODLLNOFAOG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface IINDNAJKJOB
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash KCGNLENMMHH);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface OJGAMMOCGJN : IINDNAJKJOB
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	[CanBeNull]
	byte[] BKILBMFLKEO
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	[CanBeNull]
	byte[] DABAMODEKOF
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class CMALKKBNOLE
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static bool GPCJIMLNKNN;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly ArrayPool<byte> OLJNGNHBFNJ;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly ArrayPool<char> DFCALLCCKPM;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly Encoding EBJKMLEDHOC;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly ThreadLocal<Encoder> DHJDFDHMJFK;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5AB0", Offset = "0x2AC44B0", VA = "0x182AC5AB0")]
	public static void FNCMDNHNODI<T>(this IncrementalHash APGIABIIOJI, [CanBeNull] T PHMJIJLHMJK) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5B70", Offset = "0x2AC4570", VA = "0x182AC5B70")]
	public static void FODHAMAOGLP<T>(this IncrementalHash APGIABIIOJI, [CanBeNull] T OGADBMOLAPP) where T : IINDNAJKJOB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5590", Offset = "0x2AC3F90", VA = "0x182AC5590")]
	public static void DENIPAFPHBG<T>(this IncrementalHash APGIABIIOJI, [CanBeNull] IList<T> DOMBNKOMLKG) where T : IINDNAJKJOB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6B7C2D0", Offset = "0x6B7ACD0", VA = "0x186B7C2D0")]
	private static bool ICPKEGKBLPE([CanBeNull] IINDNAJKJOB OGADBMOLAPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6B7BBD0", Offset = "0x6B7A5D0", VA = "0x186B7BBD0")]
	public static void CMDPJBNOLBP(this IncrementalHash KCGNLENMMHH, string? OEINOEKPJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6B7C640", Offset = "0x6B7B040", VA = "0x186B7C640")]
	public static void MCHBBGLGNPF(this IncrementalHash KCGNLENMMHH, long GCNCHCCOKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6B7C870", Offset = "0x6B7B270", VA = "0x186B7C870")]
	public static void OEOCNBCAIPN(this IncrementalHash KCGNLENMMHH, int NMPMDDKJOCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6B7BFD0", Offset = "0x6B7A9D0", VA = "0x186B7BFD0")]
	public static void HEEGMANFCPI(this IncrementalHash KCGNLENMMHH, short EODLIPCNMEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6B7C530", Offset = "0x6B7AF30", VA = "0x186B7C530")]
	public static void MCDHJDDCGHC(this IncrementalHash KCGNLENMMHH, byte ECPFICKFIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6B7C360", Offset = "0x6B7AD60", VA = "0x186B7C360")]
	public static void JPAONBFDFDJ(this IncrementalHash KCGNLENMMHH, bool DHGBCGFFBMB, bool HHFEFDIGBLI = false, bool KKJFAHFICLI = false, bool BKCKDICHOOM = false, bool GKCBLBNMHPA = false, bool LAILBNDEENP = false, bool GEOINJFPNOA = false, bool LDFNCMPLAAF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5C00", Offset = "0x2AC4600", VA = "0x182AC5C00")]
	public static void HFLLEMNIAAD<T>(this IncrementalHash KCGNLENMMHH, T NPGBIOOADNL) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6B7C4D0", Offset = "0x6B7AED0", VA = "0x186B7C4D0")]
	public static void KJPAFJJCECN(this IncrementalHash KCGNLENMMHH, float MPFMNAAKGAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6B7CA40", Offset = "0x6B7B440", VA = "0x186B7CA40")]
	public static void PCCMNHFDOBC(this IncrementalHash KCGNLENMMHH, ulong CJFGJMIOKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6B7BB70", Offset = "0x6B7A570", VA = "0x186B7BB70")]
	public static void CCFAMCCBHDI(this IncrementalHash KCGNLENMMHH, uint HPBNDKAFLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6B7C810", Offset = "0x6B7B210", VA = "0x186B7C810")]
	public static void NFBABALFLIE(this IncrementalHash KCGNLENMMHH, ushort GJKPLHLGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6B7C1A0", Offset = "0x6B7ABA0", VA = "0x186B7C1A0")]
	public static void HKDKMMDACIH(this IncrementalHash KCGNLENMMHH, Vector3 DPNOBOIMJKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class KHHPCOMKANL : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6B7EE00", Offset = "0x6B7D800", VA = "0x186B7EE00")]
	public KHHPCOMKANL(string MEBLNPKEJMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public abstract class KNGAPJLBCJI<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	internal class NMJMODBECAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public TNode PECHDAFMNOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public TNode DLPGBMPJIIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public MEONEHJOBKN OMFPMCIAPMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public List<MEONEHJOBKN> MEGFNKKGLNP;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public NMJMODBECAD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal struct MEONEHJOBKN : IComparable<MEONEHJOBKN>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int IMEAKFNIDBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public TClaimant CAIKIOGKOFJ;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xF46960", Offset = "0xF45360", VA = "0x180F46960")]
		public MEONEHJOBKN(int IMEAKFNIDBO, TClaimant CAIKIOGKOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x460F930", Offset = "0x460E330", VA = "0x18460F930")]
		public bool PHFFALEFOAI([In] MEONEHJOBKN AIPFCMFLDKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x460F910", Offset = "0x460E310", VA = "0x18460F910")]
		public bool CNANMPECAKL([In] MEONEHJOBKN AIPFCMFLDKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x460F920", Offset = "0x460E320", VA = "0x18460F920", Slot = "4")]
		public int CompareTo(MEONEHJOBKN AIPFCMFLDKG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x460F990", Offset = "0x460E390", VA = "0x18460F990", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public enum LEPBBEBIIDK
	{
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class KEMADABGNGB : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public KNGAPJLBCJI<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x94CA60", Offset = "0x94B460", VA = "0x18094CA60")]
		[DebuggerHidden]
		public KEMADABGNGB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4318F50", Offset = "0x4317950", VA = "0x184318F50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4319130", Offset = "0x4317B30", VA = "0x184319130", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4319030", Offset = "0x4317A30", VA = "0x184319030", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3BE6B80", Offset = "0x3BE5580", VA = "0x183BE6B80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly OKEINIHAKEB<NMJMODBECAD> HOLENJEFNKC;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly OKEINIHAKEB<List<MEONEHJOBKN>> BHLKFAMNNKP;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static int PNINOBAJNGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	internal readonly Dictionary<TClaimant, TNode> FMIHKPLLJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	internal readonly Dictionary<TNode, NMJMODBECAD> BOMJLPBCHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private LEPBBEBIIDK KLNNBBIAGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool JJAPMBJBFNG;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode JEODACCEEOI(TNode AJIEBFICGCI);

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void JDOBNHPKLJJ(TNode AJIEBFICGCI, TClaimant DNBPOEOFPMA, TClaimant JPPAMGEHIEG);

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x4395DE0", Offset = "0x43947E0", VA = "0x184395DE0")]
	public KNGAPJLBCJI(LEPBBEBIIDK KLNNBBIAGGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x4395680", Offset = "0x4394080", VA = "0x184395680")]
	public void JHKJDFHJHJB(TNode AJIEBFICGCI, TNode GOOHADCPCIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x4395070", Offset = "0x4393A70", VA = "0x184395070")]
	public void HAEPNPBOHBN(TClaimant CAIKIOGKOFJ, TNode HFAGJMLGNAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x43946B0", Offset = "0x43930B0", VA = "0x1843946B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x4395750", Offset = "0x4394150", VA = "0x184395750")]
	private void MOALMPCNAIB(TClaimant CAIKIOGKOFJ, TNode POEOINGCDKA, TNode HFAGJMLGNAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x4394BD0", Offset = "0x43935D0", VA = "0x184394BD0")]
	private int EJPECJNFGNL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x43941F0", Offset = "0x4392BF0", VA = "0x1843941F0")]
	private void BFJKNAIOHAF(TClaimant CAIKIOGKOFJ, TNode FNHGGHNPHIO, TNode BHNMAGJIIBB, int NEEGFPHCCHC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x4395820", Offset = "0x4394220", VA = "0x184395820")]
	private void PCOCAIGGKDJ(MEONEHJOBKN IKHMAOIANOK, NMJMODBECAD CMEDJJCHDOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x43948D0", Offset = "0x43932D0", VA = "0x1843948D0")]
	private void EEGDNGOPHLN(TClaimant CAIKIOGKOFJ, TNode FNHGGHNPHIO, TNode BHNMAGJIIBB, int NEEGFPHCCHC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x4394C40", Offset = "0x4393640", VA = "0x184394C40")]
	private void FDJEONCMNNP(MEONEHJOBKN IKHMAOIANOK, TNode AJIEBFICGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x4395900", Offset = "0x4394300", VA = "0x184395900")]
	private void PGKADDGLIDO(MEONEHJOBKN IKHMAOIANOK, NMJMODBECAD CMEDJJCHDOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x4394550", Offset = "0x4392F50", VA = "0x184394550")]
	private void CELNKOHBOPN(NMJMODBECAD CMEDJJCHDOH, bool LAAJDMIPNNM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x4395210", Offset = "0x4393C10", VA = "0x184395210")]
	private void HBAADIPADGF(NMJMODBECAD CMEDJJCHDOH, TNode GOOHADCPCIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x4395580", Offset = "0x4393F80", VA = "0x184395580")]
	[IteratorStateMachine(typeof(KNGAPJLBCJI<, >.KEMADABGNGB))]
	private IEnumerable<TNode> IMMLOCLGJCI(TNode FNHGGHNPHIO, TNode BHNMAGJIIBB, bool ILNKPINNMPI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x4394F50", Offset = "0x4393950", VA = "0x184394F50")]
	private NMJMODBECAD GIFDBKAMLOI(TNode AJIEBFICGCI, TNode DLPGBMPJIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x4395A70", Offset = "0x4394470", VA = "0x184395A70")]
	private NMJMODBECAD POOCGHFHGAB(TNode AJIEBFICGCI, TNode DLPGBMPJIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x4394D80", Offset = "0x4393780", VA = "0x184394D80")]
	private void FNKPDCJDFFJ(NMJMODBECAD CMEDJJCHDOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class EGLGLJGJFJK<T> : IEnumerable<EGLGLJGJFJK<T>.EEHCDIBEJIM>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public struct EEHCDIBEJIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public T CLMKDBDPNNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public int EBDDHAPIAHH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class FEOACLFBDOJ : IEnumerator<EEHCDIBEJIM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private EGLGLJGJFJK<T> HJDLPIEKGOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private int EBDDHAPIAHH;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x39B73A0", Offset = "0x39B5DA0", VA = "0x1839B73A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public EEHCDIBEJIM JOCMDMELDEE
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x3D3D190", Offset = "0x3D3BB90", VA = "0x183D3D190", Slot = "4")]
			get
			{
				return default(EEHCDIBEJIM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3D3D0A0", Offset = "0x3D3BAA0", VA = "0x183D3D0A0")]
		public FEOACLFBDOJ(EGLGLJGJFJK<T> HJDLPIEKGOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3D3CFA0", Offset = "0x3D3B9A0", VA = "0x183D3CFA0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3A0D660", Offset = "0x3A0C060", VA = "0x183A0D660", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xAD1F20", Offset = "0xAD0920", VA = "0x180AD1F20", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private struct PMMHJCBLHLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public bool IBHOFJHHKOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public T CLMKDBDPNNH;
	}

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private const int PJKAKGJPCIM = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly Dictionary<T, int> KLFGEAMDOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private PMMHJCBLHLK[] NDBCOOPODGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private int LIJIACAOBLO;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public int FIMIMNMOPGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8C3B70", Offset = "0x8C2570", VA = "0x1808C3B70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8C2FA0", Offset = "0x8C19A0", VA = "0x1808C2FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public int FPAPEBLAAHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x36CB460", Offset = "0x36C9E60", VA = "0x1836CB460")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x3965B80", Offset = "0x3964580", VA = "0x183965B80")]
	public EGLGLJGJFJK(int HBMOJAPOCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x39660C0", Offset = "0x3964AC0", VA = "0x1839660C0")]
	public EGLGLJGJFJK(EEHCDIBEJIM[] BDMLHIPOAMK, bool IPBBJDLNHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x3965420", Offset = "0x3963E20", VA = "0x183965420")]
	public int JNMDNMKJDOM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3964E70", Offset = "0x3963870", VA = "0x183964E70")]
	private int BIHNDOOPAAM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x39653F0", Offset = "0x3963DF0", VA = "0x1839653F0", Slot = "6")]
	protected virtual uint IJHDLEICCCN(uint KCGNLENMMHH, T CLMKDBDPNNH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x39651A0", Offset = "0x3963BA0", VA = "0x1839651A0")]
	public bool BPGAPCDHLML(T CLMKDBDPNNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x3965090", Offset = "0x3963A90", VA = "0x183965090")]
	public int BKBIOINDBIL(T CLMKDBDPNNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3965350", Offset = "0x3963D50", VA = "0x183965350")]
	public T FBCNBGDNDPI(int EBDDHAPIAHH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x3965A70", Offset = "0x3964470", VA = "0x183965A70")]
	public bool KPMONNEGAGF(T CLMKDBDPNNH, bool DLEFEMNLKCG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x3965800", Offset = "0x3964200", VA = "0x183965800")]
	public bool KPMONNEGAGF(T CLMKDBDPNNH, int EBDDHAPIAHH, bool DLEFEMNLKCG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x3965260", Offset = "0x3963C60", VA = "0x183965260")]
	private int DJAFJDHJNII(int GLCOHEPGOCK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x3965AE0", Offset = "0x39644E0", VA = "0x183965AE0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x3965AE0", Offset = "0x39644E0", VA = "0x183965AE0", Slot = "4")]
	private IEnumerator<EEHCDIBEJIM> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class OKEINIHAKEB<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly Stack<T> EFIHMNMKKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly List<T> MIBBLGJFHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly int NLONJEBABEI;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x4844AD0", Offset = "0x48434D0", VA = "0x184844AD0")]
	public static OKEINIHAKEB<T> LKGKDLABHKO(int HBMOJAPOCCD = 0, int NLONJEBABEI = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x4844430", Offset = "0x4842E30", VA = "0x184844430")]
	public static OKEINIHAKEB<T> AADJAPPDHED(int HBMOJAPOCCD = 0, int NLONJEBABEI = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x4844DB0", Offset = "0x48437B0", VA = "0x184844DB0")]
	public OKEINIHAKEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x4844E00", Offset = "0x4843800", VA = "0x184844E00")]
	public OKEINIHAKEB(int HBMOJAPOCCD, int NLONJEBABEI = int.MaxValue, bool LANGIJGDIDJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x4844530", Offset = "0x4842F30", VA = "0x184844530")]
	public T ADOMJAHIMBE()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x4844CD0", Offset = "0x48436D0", VA = "0x184844CD0")]
	public void NNFNKLLBHJI(T CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x4844BD0", Offset = "0x48435D0", VA = "0x184844BD0")]
	private void MMPHNGFHOJL(T CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x48446F0", Offset = "0x48430F0", VA = "0x1848446F0")]
	private void DCMOLNJOMII(T CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x4844740", Offset = "0x4843140", VA = "0x184844740", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x48448D0", Offset = "0x48432D0", VA = "0x1848448D0")]
	private void ILAHGODGOHL(IEnumerable<T> ACOKCANBLGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class PHACPCGPPGA<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private Dictionary<int, T> EDBFMFKGPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private T PMNFNNJABNF;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public virtual T POFNMNFEGOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x885AE0", Offset = "0x8844E0", VA = "0x180885AE0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x4931470", Offset = "0x492FE70", VA = "0x184931470")]
	public bool CFGPJGNDHFC(T CLMKDBDPNNH, int IMEAKFNIDBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x4237E80", Offset = "0x4236880", VA = "0x184237E80")]
	public bool JAABMHIDLLO(int IMEAKFNIDBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x4931580", Offset = "0x492FF80", VA = "0x184931580")]
	public T HMKPEPKKCLF(int KBDAKABIEGE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x4931A50", Offset = "0x4930450", VA = "0x184931A50")]
	private bool IGGGPGHLJLC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x4931520", Offset = "0x492FF20", VA = "0x184931520")]
	public bool DCBHEAIHJLO(int IMEAKFNIDBO, [Out] T CLMKDBDPNNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x4237F30", Offset = "0x4236930", VA = "0x184237F30")]
	public PHACPCGPPGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class FNODOPJPFEC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	protected struct HNABHFFDKNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public T GJBIHCLEEHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public int AEBIOBELCCD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	protected readonly List<HNABHFFDKNH> DOJFLIMJFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private T LBPDMGFEJJP;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public int FPAPEBLAAHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x36CB460", Offset = "0x36C9E60", VA = "0x1836CB460")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x3D69080", Offset = "0x3D67A80", VA = "0x183D69080")]
	public bool BNBIAOAJEAG(T CLMKDBDPNNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x3D69650", Offset = "0x3D68050", VA = "0x183D69650")]
	public void EGHPKMGPEOO(T CLMKDBDPNNH, int IMEAKFNIDBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x3D697C0", Offset = "0x3D681C0", VA = "0x183D697C0")]
	public bool MIOFMOMIMDC(T CLMKDBDPNNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x3D69710", Offset = "0x3D68110", VA = "0x183D69710")]
	public void IMAFILHGCCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x3D69430", Offset = "0x3D67E30", VA = "0x183D69430")]
	public T DGDHFGIGGMK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x3D69B60", Offset = "0x3D68560", VA = "0x183D69B60")]
	protected void NACFLDLKEDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x3D69E40", Offset = "0x3D68840", VA = "0x183D69E40")]
	public FNODOPJPFEC()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		[SerializeField]
		[EHNJJNMEJEA(BILCJMODHFE.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x6B7F490", Offset = "0x6B7DE90", VA = "0x186B7F490")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x6B7F760", Offset = "0x6B7E160", VA = "0x186B7F760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x6B7F670", Offset = "0x6B7E070", VA = "0x186B7F670")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x6B7F3E0", Offset = "0x6B7DDE0", VA = "0x186B7F3E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x6B7F6B0", Offset = "0x6B7E0B0", VA = "0x186B7F6B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x6B7F5C0", Offset = "0x6B7DFC0", VA = "0x186B7F5C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6B7F360", Offset = "0x6B7DD60", VA = "0x186B7F360")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x4AECC80", Offset = "0x4AEB680", VA = "0x184AECC80", Slot = "4")]
		public virtual T FMDEFAPPBKG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class GCFIBKGKNHK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private Dictionary<byte, APDOGLHJAEM> CHGFHJABCAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private readonly OKEINIHAKEB<APDOGLHJAEM> OECMGKOFKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly bool PDJCELHAFAE;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public APDOGLHJAEM OPBHKMIIAPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x882790", Offset = "0x881190", VA = "0x180882790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Vector2 ALFOOEKNNKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xECD9C0", Offset = "0xECC3C0", VA = "0x180ECD9C0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x11DFE70", Offset = "0x11DE870", VA = "0x1811DFE70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	private Vector2 POPONMFAGKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x120D590", Offset = "0x120BF90", VA = "0x18120D590")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Vector2 IOOEFAOAAFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6B7DDA0", Offset = "0x6B7C7A0", VA = "0x186B7DDA0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x891460", Offset = "0x88FE60", VA = "0x180891460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int EGKILDLOHOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x886B70", Offset = "0x885570", VA = "0x180886B70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x886980", Offset = "0x885380", VA = "0x180886980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6B7EB40", Offset = "0x6B7D540", VA = "0x186B7EB40")]
	public GCFIBKGKNHK(Bounds FOKANEAFBEC, Vector2[] BIMMEDBJIFF, int DEJAGHDNHJH, byte GLCOHEPGOCK, float MBGCPEHALBN = 0f, [Optional] OKEINIHAKEB<APDOGLHJAEM> OECMGKOFKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6B7E470", Offset = "0x6B7CE70", VA = "0x186B7E470")]
	public void NKAGKGKIGHM(Bounds FOKANEAFBEC, Vector2[] BIMMEDBJIFF, int DEJAGHDNHJH, byte GLCOHEPGOCK, float MBGCPEHALBN = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6B7DE20", Offset = "0x6B7C820", VA = "0x186B7DE20")]
	public APDOGLHJAEM EMIADLKEOCH(byte EBDDHAPIAHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6B7DF00", Offset = "0x6B7C900", VA = "0x186B7DF00")]
	public void GNEFIOEEEPM(Vector3 BJDHDJCINFH, float GGMLBJOFABP, float OMOKDGDAEHG, List<byte> NAJDGPPAAHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6B7DEE0", Offset = "0x6B7C8E0", VA = "0x186B7DEE0")]
	public void GCKCGIOJBCK(APDOGLHJAEM.KFNLDEKPOJE BEFALKLJGGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6B7E380", Offset = "0x6B7CD80", VA = "0x186B7E380")]
	public static int MILIODLGGAL(Vector2[] BIMMEDBJIFF, int DEJAGHDNHJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6B7E910", Offset = "0x6B7D310", VA = "0x186B7E910")]
	private APDOGLHJAEM OAMIAGLMCIO(byte EBDDHAPIAHH, APDOGLHJAEM.PBEIFFIDNPP GGOPEGECBPE, APDOGLHJAEM DLPGBMPJIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6B7DFD0", Offset = "0x6B7C9D0", VA = "0x186B7DFD0")]
	private void HHJAPKGNIAB(APDOGLHJAEM DLPGBMPJIIG, Vector2[] BIMMEDBJIFF, int IHDLHIFDHPH, int ECLFEHPCDNC, int OKEIFOFMHKJ, int FCLHPOBBHGI, float MBGCPEHALBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6B7DB80", Offset = "0x6B7C580", VA = "0x186B7DB80")]
	private void CHLPFGLGKJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6B7DDC0", Offset = "0x6B7C7C0", VA = "0x186B7DDC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6B7DE80", Offset = "0x6B7C880", VA = "0x186B7DE80", Slot = "1")]
	~GCFIBKGKNHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class APDOGLHJAEM
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public enum PBEIFFIDNPP
	{
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public enum KFNLDEKPOJE
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public byte KLCNCHBCNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public Vector3 OKDOINDOEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public Vector3 GCMPBODBNPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public Vector3 COIOIPEKNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public Vector3 BANNLOMDBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public PBEIFFIDNPP HECDNPKOJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public APDOGLHJAEM GCDGMCMKOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public List<APDOGLHJAEM> BCLPNCICACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public bool BFPGEPBKAEC;

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x6B7B8F0", Offset = "0x6B7A2F0", VA = "0x186B7B8F0")]
	public APDOGLHJAEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6B7B490", Offset = "0x6B79E90", VA = "0x186B7B490")]
	public void FEKGBLJAANA(APDOGLHJAEM FGMPPONDFPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	public void GCKCGIOJBCK(int OECOJFNCCCA, KFNLDEKPOJE BEFALKLJGGF, int PBPFMICJHGL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x6B7B5D0", Offset = "0x6B79FD0", VA = "0x186B7B5D0")]
	public void GNEFIOEEEPM(List<byte> NAJDGPPAAHM, Vector3 BJDHDJCINFH, float GGMLBJOFABP, float OMOKDGDAEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x6B7B830", Offset = "0x6B7A230", VA = "0x186B7B830")]
	public bool LEPCBLDNKPH(Vector3 LPCMJKGGJFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x6B7B460", Offset = "0x6B79E60", VA = "0x186B7B460")]
	public bool EGGKHPCHDKI(Vector3 LPCMJKGGJFF, float ALMNHPDNHCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6B7B860", Offset = "0x6B7A260", VA = "0x186B7B860")]
	public void PCEEADECCDH()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		public struct EICFEOKHHKB<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private readonly List<Component> JNHGBAGBHGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private readonly bool HJMPHOKBEGH;

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x3972910", Offset = "0x3971310", VA = "0x183972910")]
			public EICFEOKHHKB(List<Component> JNHGBAGBHGA, bool HJMPHOKBEGH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x39727D0", Offset = "0x39711D0", VA = "0x1839727D0")]
			public AOOBCPKHBGA<T> BPGPEIEKEPK()
			{
				return default(AOOBCPKHBGA<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x3972840", Offset = "0x3971240", VA = "0x183972840", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x3972840", Offset = "0x3971240", VA = "0x183972840", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006E")]
		public struct AOOBCPKHBGA<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			private readonly List<Component> JNHGBAGBHGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			private readonly bool HJMPHOKBEGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			private int EBDDHAPIAHH;

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public T JOCMDMELDEE
			{
				[Cpp2IlInjected.Token(Token = "0x600021A")]
				[Cpp2IlInjected.Address(RVA = "0x3E48360", Offset = "0x3E46D60", VA = "0x183E48360", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000061")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600021B")]
				[Cpp2IlInjected.Address(RVA = "0x3E482F0", Offset = "0x3E46CF0", VA = "0x183E482F0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x3E48330", Offset = "0x3E46D30", VA = "0x183E48330")]
			public AOOBCPKHBGA(List<Component> JNHGBAGBHGA, bool HJMPHOKBEGH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x3E48230", Offset = "0x3E46C30", VA = "0x183E48230", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x3E48240", Offset = "0x3E46C40", VA = "0x183E48240", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x3A00870", Offset = "0x39FF270", VA = "0x183A00870", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x6B81180", Offset = "0x6B7FB80", VA = "0x186B81180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6B80BA0", Offset = "0x6B7F5A0", VA = "0x186B80BA0")]
		private void PCEEADECCDH(GameObject BCHIECCDCEC, bool MOFNDFHCJJC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x6B80D10", Offset = "0x6B7F710", VA = "0x186B80D10")]
		public static void PCEEADECCDH(GameObject BCHIECCDCEC, ToolHierarchyCache INKPCFGBNLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6B80AA0", Offset = "0x6B7F4A0", VA = "0x186B80AA0")]
		public void AMHEMPPILKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x2FAD640", Offset = "0x2FAC040", VA = "0x182FAD640")]
		public void EEFNCIPBKKP<T>(Action<T> ENNGIICFMFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x2FAD880", Offset = "0x2FAC280", VA = "0x182FAD880")]
		public T KHBICADJMON<T>(bool HJMPHOKBEGH = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x2FAD920", Offset = "0x2FAC320", VA = "0x182FAD920")]
		public EICFEOKHHKB<T> MOAGNOPEIGM<T>(bool HJMPHOKBEGH = false) where T : class
		{
			return default(EICFEOKHHKB<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6B80DA0", Offset = "0x6B7F7A0", VA = "0x186B80DA0")]
		public List<Component> PCIGONCGFJD(Type NNCMOPPBEEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x6B80AB0", Offset = "0x6B7F4B0", VA = "0x186B80AB0", Slot = "4")]
		public bool Equals(ToolHierarchyCache ICJCFEHCALD, ToolHierarchyCache MPEFCGEJLMG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x6B80B30", Offset = "0x6B7F530", VA = "0x186B80B30", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache GIGIFGONEAO)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class NANIHFHFJGH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int HBMOJAPOCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int AFMEBJBEDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private List<T> ANCDMKKBECA;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int FPAPEBLAAHL
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x4007A00", Offset = "0x4006400", VA = "0x184007A00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public T IDCAEDBDIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x4698140", Offset = "0x4696B40", VA = "0x184698140")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public T EAGLKEMFBMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x4698310", Offset = "0x4696D10", VA = "0x184698310")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public T PBGCBBIHFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x4698220", Offset = "0x4696C20", VA = "0x184698220")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x4698400", Offset = "0x4696E00", VA = "0x184698400")]
	public NANIHFHFJGH(int HBMOJAPOCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x4697D80", Offset = "0x4696780", VA = "0x184697D80")]
	public void EGHPKMGPEOO(T KBMECHFKKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x4697F00", Offset = "0x4696900", VA = "0x184697F00")]
	public void IMAFILHGCCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x4697B10", Offset = "0x4696510", VA = "0x184697B10")]
	public void BHJFJJNODGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x4698000", Offset = "0x4696A00", VA = "0x184698000")]
	public void LOLJIFFOLIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x4697EF0", Offset = "0x46968F0", VA = "0x184697EF0")]
	public void ELLGNMPNGEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x4697F60", Offset = "0x4696960", VA = "0x184697F60")]
	public List<T> LFODLGHHGLG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class GGFGBHHMPMM<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private struct PFAGLACAGCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public int AEBIOBELCCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public T GJBIHCLEEHA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly Dictionary<object, PFAGLACAGCK> EDBFMFKGPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly EqualityComparer<T> AGCLIHGJING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private T PMNFNNJABNF;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public virtual T POFNMNFEGOC
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xA3F130", Offset = "0xA3DB30", VA = "0x180A3F130", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x3E12C70", Offset = "0x3E11670", VA = "0x183E12C70", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public bool PIIEJFCEHBH
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x3E0F470", Offset = "0x3E0DE70", VA = "0x183E0F470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public object DMBCIHMMGPH
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8893E0", Offset = "0x887DE0", VA = "0x1808893E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8893D0", Offset = "0x887DD0", VA = "0x1808893D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x3E0F090", Offset = "0x3E0DA90", VA = "0x183E0F090")]
	public bool CFGPJGNDHFC(T CLMKDBDPNNH, object KLGLJKMNAIM, int IMEAKFNIDBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x3E12B70", Offset = "0x3E11570", VA = "0x183E12B70")]
	public bool JAABMHIDLLO(object KLGLJKMNAIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x3E0F7D0", Offset = "0x3E0E1D0", VA = "0x183E0F7D0")]
	public bool DCBHEAIHJLO(object KLGLJKMNAIM, [Out] T CLMKDBDPNNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x3E12B10", Offset = "0x3E11510", VA = "0x183E12B10")]
	public void IMAFILHGCCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x3E11430", Offset = "0x3E0FE30", VA = "0x183E11430")]
	private bool IGGGPGHLJLC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x3E12D00", Offset = "0x3E11700", VA = "0x183E12D00")]
	public GGFGBHHMPMM()
	{
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
