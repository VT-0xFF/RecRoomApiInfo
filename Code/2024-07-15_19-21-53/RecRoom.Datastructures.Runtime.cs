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
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87AEC0", VA = "0x18087C6C0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x68AB670", Offset = "0x68A9E70", VA = "0x1868AB670")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87D9C0", Offset = "0x87C1C0", VA = "0x18087D9C0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x87DA00", Offset = "0x87C200", VA = "0x18087DA00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class OGEGJKMLCNM : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x14DD360", Offset = "0x14DBB60", VA = "0x1814DD360")]
	public OGEGJKMLCNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, CEAGNJHJOCG, FOEMIFIPDHC, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x852890", Offset = "0x851090", VA = "0x180852890", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8510A0", VA = "0x1808528A0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x852870", Offset = "0x851070", VA = "0x180852870", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x91F460", Offset = "0x91DC60", VA = "0x18091F460", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash BGMAOMLOOIC);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8BEAE0", Offset = "0x8BD2E0", VA = "0x1808BEAE0")]
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
	[SerializeField]
	[ReadOnlyField]
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
		[Cpp2IlInjected.Address(RVA = "0x68ACA70", Offset = "0x68AB270", VA = "0x1868ACA70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x68ACA30", Offset = "0x68AB230", VA = "0x1868ACA30")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x68ACAB0", Offset = "0x68AB2B0", VA = "0x1868ACAB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x68ACC60", Offset = "0x68AB460", VA = "0x1868ACC60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x68ACBD0", Offset = "0x68AB3D0", VA = "0x1868ACBD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8BEAD0", Offset = "0x8BD2D0", VA = "0x1808BEAD0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8BEA90", Offset = "0x8BD290", VA = "0x1808BEA90")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x68AC9F0", Offset = "0x68AB1F0", VA = "0x1868AC9F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x68ACB40", Offset = "0x68AB340", VA = "0x1868ACB40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x68AC460", Offset = "0x68AAC60", VA = "0x1868AC460")]
	public void CopyBounds(SavedExtents OKGBBGMIACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x68AC940", Offset = "0x68AB140", VA = "0x1868AC940")]
	public void SetLocalSpaceBounds(Bounds IFKDOLFNMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xBB0F20", Offset = "0xBAF720", VA = "0x180BB0F20")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x68AC930", Offset = "0x68AB130", VA = "0x1868AC930")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x68AC490", Offset = "0x68AAC90", VA = "0x1868AC490")]
	private void ECNBNJLLBEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x68AC710", Offset = "0x68AAF10", VA = "0x1868AC710")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x68ABDF0", Offset = "0x68AA5F0", VA = "0x1868ABDF0")]
	public static void CalculateLocalBoundsFor(GameObject NBDLDMDNCAL, [Out] Bounds IFKDOLFNMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x68AC650", Offset = "0x68AAE50", VA = "0x1868AC650")]
	private static void IEHMKCEKBOJ(Bounds GANEOONFJPD, Color DDJHOHBDMLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x68AC960", Offset = "0x68AB160", VA = "0x1868AC960")]
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
		[Cpp2IlInjected.Address(RVA = "0x8521A0", Offset = "0x8509A0", VA = "0x1808521A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x852910", Offset = "0x851110", VA = "0x180852910")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xFD17C0", Offset = "0xFCFFC0", VA = "0x180FD17C0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4955C50", Offset = "0x4954450", VA = "0x184955C50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "4")]
	public virtual void IBAMJKALAJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
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
	[SerializeField]
	[OGEGJKMLCNM]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x49557D0", Offset = "0x4953FD0", VA = "0x1849557D0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4953FE0", Offset = "0x49527E0", VA = "0x184953FE0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4955B50", Offset = "0x4954350", VA = "0x184955B50")]
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
	private sealed class PLJLHLCOBLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public PLJLHLCOBLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4770460", Offset = "0x476EC60", VA = "0x184770460")]
		internal int GBKFKGKKNGO(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[OGEGJKMLCNM]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x380D710", Offset = "0x380BF10", VA = "0x18380D710", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x380D770", Offset = "0x380BF70", VA = "0x18380D770", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x380D5F0", Offset = "0x380BDF0", VA = "0x18380D5F0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey NDDCLPHCEEO]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x380D6B0", Offset = "0x380BEB0", VA = "0x18380D6B0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x380D4A0", Offset = "0x380BCA0", VA = "0x18380D4A0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x380D160", Offset = "0x380B960", VA = "0x18380D160", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x380C580", Offset = "0x380AD80", VA = "0x18380C580", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x380C550", Offset = "0x380AD50", VA = "0x18380C550", Slot = "14")]
	protected virtual string IMEGMNFCIOH(TKeyVal HDDCDBLOLDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x380C3F0", Offset = "0x380ABF0", VA = "0x18380C3F0", Slot = "4")]
	public bool ContainsKey(TKey NDDCLPHCEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x380D320", Offset = "0x380BB20", VA = "0x18380D320", Slot = "5")]
	public bool TryGetValue(TKey NDDCLPHCEEO, [Out] TVal JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x380C450", Offset = "0x380AC50", VA = "0x18380C450", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x380C450", Offset = "0x380AC50", VA = "0x18380C450", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x380D380", Offset = "0x380BB80", VA = "0x18380D380")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class NHJHDBAJGNN<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class GMBLGKIIJEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public float IOIJNMIIHIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public T JNHPIMBJPMJ;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public GMBLGKIIJEI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class IBHPFKJNGPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public IBHPFKJNGPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3E1A7C0", Offset = "0x3E18FC0", VA = "0x183E1A7C0")]
		internal bool NPHOCHGOIIC(GMBLGKIIJEI sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly float HCKDDPKCGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly float KJMCBPIHFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<GMBLGKIIJEI> LFOOMPFBGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CAJPHPCFPPJ<GMBLGKIIJEI> JIIKGPMGFHC;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int GJGOIKGCHNA
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x450C280", Offset = "0x450AA80", VA = "0x18450C280")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x450C2F0", Offset = "0x450AAF0", VA = "0x18450C2F0")]
	public NHJHDBAJGNN(float KJHHCJADBDH, float DHJINKLHOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x450B550", Offset = "0x4509D50", VA = "0x18450B550")]
	public bool HMBECCONFBC(float HDCBOMJHFCH, T JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x450BD00", Offset = "0x450A500", VA = "0x18450BD00")]
	public IEnumerable<T> IOMCBEOMABD(float HDCBOMJHFCH, [Optional] float? IALGELGJOKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x450B8E0", Offset = "0x450A0E0", VA = "0x18450B8E0")]
	public void IMJJLGNDCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x450C070", Offset = "0x450A870", VA = "0x18450C070")]
	private void JPNMHHBOHFG(float HDCBOMJHFCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class OKINFAONJHL<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct PPDEGLHINBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public T JNHPIMBJPMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public float MOEHEJACJEH;
	}

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static float MPGMGLKLEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private List<T> MHBAABDANFO;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private const int PJPGAPLLDJA = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private PPDEGLHINBJ[] PFKJAOOHGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int FGHIONIHMHA;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float LCLMKPJCKGN
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9A3BE0", Offset = "0x9A23E0", VA = "0x1809A3BE0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9AC630", Offset = "0x9AAE30", VA = "0x1809AC630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4661A60", Offset = "0x4660260", VA = "0x184661A60")]
	public OKINFAONJHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4661AA0", Offset = "0x46602A0", VA = "0x184661AA0")]
	public OKINFAONJHL(int ECGAAJFODGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4661800", Offset = "0x4660000", VA = "0x184661800")]
	public void PBLNBBGFGAP(float HDCBOMJHFCH, T JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x46616C0", Offset = "0x465FEC0", VA = "0x1846616C0")]
	public void IMJJLGNDCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4661040", Offset = "0x465F840", VA = "0x184661040")]
	public bool BCABLAINCKG(float NCEEMEKPLHO, float GEHGKBEMJPC, [Out] T JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x46609A0", Offset = "0x465F1A0", VA = "0x1846609A0")]
	public bool ADNNIEHGPNG(float NCEEMEKPLHO, float GEHGKBEMJPC, [Out] T JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4661290", Offset = "0x465FA90", VA = "0x184661290")]
	public void DMHNGCDMEIP(float NCEEMEKPLHO, float GEHGKBEMJPC, List<T> PHMDIHEJOGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x46615A0", Offset = "0x465FDA0", VA = "0x1846615A0")]
	private int ECAMDGGGKKL(int FJGMLNHLPBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x46617B0", Offset = "0x465FFB0", VA = "0x1846617B0")]
	private void OKIBDCKHELL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T LIADPNCJBOP();

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T KCBPOPNLEFI(T JMDCGOKJIDA, float DOGPFNGIKMO);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T GCKOMEIBJIG(T DIAAOCPNHKC, T LLLBDLGIMPP);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T JEGNKKKIMIH(T DIAAOCPNHKC, T LLLBDLGIMPP);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class AILGIAAEDNM : OKINFAONJHL<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x862EA0", Offset = "0x8616A0", VA = "0x180862EA0", Slot = "4")]
	protected override Vector3 LIADPNCJBOP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x68A7A20", Offset = "0x68A6220", VA = "0x1868A7A20", Slot = "5")]
	protected override Vector3 KCBPOPNLEFI(Vector3 JMDCGOKJIDA, float DOGPFNGIKMO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x68A7950", Offset = "0x68A6150", VA = "0x1868A7950", Slot = "6")]
	protected override Vector3 GCKOMEIBJIG(Vector3 DIAAOCPNHKC, Vector3 LLLBDLGIMPP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x68A79A0", Offset = "0x68A61A0", VA = "0x1868A79A0", Slot = "7")]
	protected override Vector3 JEGNKKKIMIH(Vector3 DIAAOCPNHKC, Vector3 LLLBDLGIMPP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x68A7A60", Offset = "0x68A6260", VA = "0x1868A7A60")]
	public AILGIAAEDNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class FLHLDIOPFJL
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2B17210", Offset = "0x2B15A10", VA = "0x182B17210")]
	public static KKNLDOICDLK<T1, T2> JGIIBNEOBDO<T1, T2>(T1 BCCJLCECHOM, T2 HEMMFIBMKDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2B172A0", Offset = "0x2B15AA0", VA = "0x182B172A0")]
	public static PLNCJGBCMBC<T1, T2, T3> JGIIBNEOBDO<T1, T2, T3>(T1 BCCJLCECHOM, T2 HEMMFIBMKDK, T3 EFGMBOCFEML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x44E17C0", Offset = "0x44DFFC0", VA = "0x1844E17C0")]
	internal static int EPAFINGNDJL(int HEOPLAHHFAB, int GJOFFMCMAIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5C58920", Offset = "0x5C57120", VA = "0x185C58920")]
	internal static int EPAFINGNDJL(int HEOPLAHHFAB, int GJOFFMCMAIA, int OAKJCPFALKN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KKNLDOICDLK<T1, T2> : IComparable<KKNLDOICDLK<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly T1 MMILKMINAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly T2 NDNGJEJEBEB;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4187730", Offset = "0x4185F30", VA = "0x184187730")]
	public KKNLDOICDLK(T1 BCCJLCECHOM, T2 HEMMFIBMKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4185960", Offset = "0x4184160", VA = "0x184185960", Slot = "4")]
	public int CompareTo(KKNLDOICDLK<T1, T2> OKGBBGMIACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x41867E0", Offset = "0x4184FE0", VA = "0x1841867E0", Slot = "0")]
	public override bool Equals(object OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4186CF0", Offset = "0x41854F0", VA = "0x184186CF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4187090", Offset = "0x4185890", VA = "0x184187090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class PLNCJGBCMBC<T1, T2, T3> : IComparable<PLNCJGBCMBC<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly T1 MMILKMINAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly T2 NDNGJEJEBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly T3 GBLLJADMCBN;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4770F40", Offset = "0x476F740", VA = "0x184770F40")]
	public PLNCJGBCMBC(T1 BCCJLCECHOM, T2 HEMMFIBMKDK, T3 EFGMBOCFEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4770770", Offset = "0x476EF70", VA = "0x184770770", Slot = "4")]
	public int CompareTo(PLNCJGBCMBC<T1, T2, T3> OKGBBGMIACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x47708C0", Offset = "0x476F0C0", VA = "0x1847708C0", Slot = "0")]
	public override bool Equals(object OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4770BE0", Offset = "0x476F3E0", VA = "0x184770BE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4770C80", Offset = "0x476F480", VA = "0x184770C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T JNHPIMBJPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x22FB360", Offset = "0x22F9B60", VA = "0x1822FB360")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x22FB420", Offset = "0x22F9C20", VA = "0x1822FB420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float MLAFKOALCDL
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8BEA30", Offset = "0x8BD230", VA = "0x1808BEA30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4BB6670", Offset = "0x4BB4E70", VA = "0x184BB6670")]
	public T FNEDDDIBHBA(float DOGPFNGIKMO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4BB67A0", Offset = "0x4BB4FA0", VA = "0x184BB67A0")]
	public T LIEECAELOJE(float DOGPFNGIKMO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T DADNJNHMGGO(T DIAAOCPNHKC, T LLLBDLGIMPP, float DOGPFNGIKMO);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x68A9000", Offset = "0x68A7800", VA = "0x1868A9000", Slot = "4")]
	protected override float DADNJNHMGGO(float DIAAOCPNHKC, float LLLBDLGIMPP, float DOGPFNGIKMO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x68A9040", Offset = "0x68A7840", VA = "0x1868A9040")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xE6EF40", Offset = "0xE6D740", VA = "0x180E6EF40", Slot = "4")]
	protected override Vector3 DADNJNHMGGO(Vector3 DIAAOCPNHKC, Vector3 LLLBDLGIMPP, float DOGPFNGIKMO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x68ADA70", Offset = "0x68AC270", VA = "0x1868ADA70")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x68A7E20", Offset = "0x68A6620", VA = "0x1868A7E20", Slot = "4")]
	protected override Color DADNJNHMGGO(Color DIAAOCPNHKC, Color LLLBDLGIMPP, float DOGPFNGIKMO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x68A7EE0", Offset = "0x68A66E0", VA = "0x1868A7EE0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class JNMGJLGBACE : DLCLPGKFPDM<string>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x68AA440", Offset = "0x68A8C40", VA = "0x1868AA440")]
	public JNMGJLGBACE(int HHGNDILCLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x68AA3D0", Offset = "0x68A8BD0", VA = "0x1868AA3D0", Slot = "6")]
	protected override uint MNAKOEMGGBL(uint BGMAOMLOOIC, string JMDCGOKJIDA)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class BMKFGIADLGO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly IDisposable MJFJCBEEADM;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
	public BMKFGIADLGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct CAAPJJNLHNO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> IMABLLPDOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int PEIHIHFNBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int LNJGPIPEBPK;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3C077F0", Offset = "0x3C05FF0", VA = "0x183C077F0")]
	private CAAPJJNLHNO(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> AICLDAIHHEE, int DLDADAOHCHO, int BPFNHEMHBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x500C090", Offset = "0x500A890", VA = "0x18500C090")]
	public static CAAPJJNLHNO<T> FJAAFKPDAIA()
	{
		return default(CAAPJJNLHNO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x500CFB0", Offset = "0x500B7B0", VA = "0x18500CFB0")]
	public (int, int, Task<T>) JPFOMCJKBNN(int IEJKLFLAGBB, [Optional] CancellationToken MPLGBOFHPLM, double IOCCJIJEELD = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x500E150", Offset = "0x500C950", VA = "0x18500E150")]
	public void KIJDNFKPHIA(int IEJKLFLAGBB, int BPFNHEMHBMJ, [In] T ADPMAHMCGNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class CIFEGFPFPGG
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x68A7B40", Offset = "0x68A6340", VA = "0x1868A7B40")]
	public static CAAPJJNLHNO<MOOMEEOMEEK> FJAAFKPDAIA()
	{
		return default(CAAPJJNLHNO<MOOMEEOMEEK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x68A7B90", Offset = "0x68A6390", VA = "0x1868A7B90")]
	public static void KIJDNFKPHIA([In] this CAAPJJNLHNO<MOOMEEOMEEK> HIKEOGPAJAF, int IEJKLFLAGBB, int BPFNHEMHBMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class NOGDILHKBGL<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<TKey, TVal> MDEEENOGJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly Dictionary<TVal, TKey> AMBOIAGLBDA;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3582930", Offset = "0x3581130", VA = "0x183582930", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool HNPAFAKBDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x8999F0", VA = "0x18089B1F0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> FBJILCMLFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3D06B40", Offset = "0x3D05340", VA = "0x183D06B40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> PGIKKFOHHOG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x4533630", Offset = "0x4531E30", VA = "0x184533630", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x4539D30", Offset = "0x4538530", VA = "0x184539D30", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4539D90", Offset = "0x4538590", VA = "0x184539D90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x45399E0", Offset = "0x45381E0", VA = "0x1845399E0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4539350", Offset = "0x4537B50", VA = "0x184539350", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4539B60", Offset = "0x4538360", VA = "0x184539B60", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4539140", Offset = "0x4537940", VA = "0x184539140", Slot = "9")]
	public void Add(TKey NDDCLPHCEEO, TVal JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x45390F0", Offset = "0x45378F0", VA = "0x1845390F0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> JNHGHHKKNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x37DB2F0", Offset = "0x37D9AF0", VA = "0x1837DB2F0", Slot = "8")]
	public bool ContainsKey(TKey NDDCLPHCEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4539430", Offset = "0x4537C30", VA = "0x184539430", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> JNHGHHKKNBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4539A50", Offset = "0x4538250", VA = "0x184539A50", Slot = "10")]
	public bool Remove(TKey NDDCLPHCEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4539AD0", Offset = "0x45382D0", VA = "0x184539AD0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> JNHGHHKKNBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4539BB0", Offset = "0x45383B0", VA = "0x184539BB0", Slot = "11")]
	public bool TryGetValue(TKey NDDCLPHCEEO, [Out] TVal JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x45398E0", Offset = "0x45380E0", VA = "0x1845398E0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4539470", Offset = "0x4537C70", VA = "0x184539470", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] PFKJAOOHGBN, int OMHDEOJLLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4538FB0", Offset = "0x45377B0", VA = "0x184538FB0")]
	public bool AKPHPFIGELN(TVal NDDCLPHCEEO, [Out] TKey JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4539190", Offset = "0x4537990", VA = "0x184539190")]
	private void CJHLJHDOGME(TKey NDDCLPHCEEO, TVal GPBAFILNEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x45395C0", Offset = "0x4537DC0", VA = "0x1845395C0")]
	private void DMBPGBGBDFN(TKey NDDCLPHCEEO, TVal GPBAFILNEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x45396B0", Offset = "0x4537EB0", VA = "0x1845396B0")]
	private bool FIHONAPKJEP(TKey NDDCLPHCEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4539C10", Offset = "0x4538410", VA = "0x184539C10")]
	public NOGDILHKBGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[DefaultMember("Item")]
public class HIGMIECILNG<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private HIGMIECILNG<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x38564B0", Offset = "0x3854CB0", VA = "0x1838564B0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x3869BF0", Offset = "0x38683F0", VA = "0x183869BF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x386A750", Offset = "0x3868F50", VA = "0x18386A750")]
		public Enumerator(HIGMIECILNG<T> PHMDIHEJOGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x3868EA0", Offset = "0x38676A0", VA = "0x183868EA0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3869470", Offset = "0x3867C70", VA = "0x183869470", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x38682B0", Offset = "0x3866AB0", VA = "0x1838682B0")]
		private void LKFPEHKNIBA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private T[] GOKDLEPEPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private int JHEGPJBDKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int MLNHFJAKLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int DMDAEILPBHA;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3D184E0", Offset = "0x3D16CE0", VA = "0x183D184E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3D19430", Offset = "0x3D17C30", VA = "0x183D19430")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x3D17A60", Offset = "0x3D16260", VA = "0x183D17A60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3D19980", Offset = "0x3D18180", VA = "0x183D19980")]
	public HIGMIECILNG(int HHGNDILCLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3D18900", Offset = "0x3D17100", VA = "0x183D18900")]
	public void PBLNBBGFGAP(T DOGPFNGIKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3D18490", Offset = "0x3D16C90", VA = "0x183D18490")]
	public void IMJJLGNDCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3D17880", Offset = "0x3D16080", VA = "0x183D17880")]
	public void CFDMGAKBOCA(int IHGHLPOONHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3D19230", Offset = "0x3D17A30", VA = "0x183D19230")]
	public void PGKLAMLJNDJ(T[] PFKJAOOHGBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3D17950", Offset = "0x3D16150", VA = "0x183D17950")]
	public Enumerator DCPEOMEKOMK()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3D196A0", Offset = "0x3D17EA0", VA = "0x183D196A0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3D196A0", Offset = "0x3D17EA0", VA = "0x183D196A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3D17EF0", Offset = "0x3D166F0", VA = "0x183D17EF0")]
	private int GCBALGANIKP(int DHNLEFJCEAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3D184B0", Offset = "0x3D16CB0", VA = "0x183D184B0")]
	private int MFMMGBJNFFA(int DHNLEFJCEAH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class LLNBPHOHMNO<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate Task<TResult> AKDEOCDHLMJ(TRequest GPCNCGBOPJG, CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public enum OEDKJEMJDGI
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class EBKBHGJMDMP
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private const float IKEDAOAHOHD = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TimeSpan IAIKPKJLIMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int DIJGBCNBBGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public OEDKJEMJDGI EOMEDHLEFLE;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly EBKBHGJMDMP ELIKMDBCIKF;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float BPMKKGOMHCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x37D17C0", Offset = "0x37CFFC0", VA = "0x1837D17C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public TimeSpan GPPHPNDKNGE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851900", VA = "0x180853100")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x37D1980", Offset = "0x37D0180", VA = "0x1837D1980")]
		public EBKBHGJMDMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private readonly struct PFKJFMEHMOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly TRequest GPCNCGBOPJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly CancellationToken MPLGBOFHPLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly TaskCompletionSource<TResult> KLCFJBFNJKE;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x47610F0", Offset = "0x475F8F0", VA = "0x1847610F0")]
		public PFKJFMEHMOJ(TRequest GPCNCGBOPJG, TaskCompletionSource<TResult> KLCFJBFNJKE, CancellationToken MPLGBOFHPLM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct AANEIBFALJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public LLNBPHOHMNO<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3C51680", Offset = "0x3C4FE80", VA = "0x183C51680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x3C51AE0", Offset = "0x3C502E0", VA = "0x183C51AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct MLNAIEAFIFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public LLNBPHOHMNO<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private PFKJFMEHMOJ <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x44A8400", Offset = "0x44A6C00", VA = "0x1844A8400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x44A9080", Offset = "0x44A7880", VA = "0x1844A9080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly CancellationTokenSource CIHCAICIHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly List<PFKJFMEHMOJ> LKJHDMOCNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly EBKBHGJMDMP EPIPNOBBMOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly AKDEOCDHLMJ GCFLFLFKPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Task IOBENEJNNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private int FDMFJIHCLBE;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x428E060", Offset = "0x428C860", VA = "0x18428E060")]
	public LLNBPHOHMNO(AKDEOCDHLMJ GCFLFLFKPOA, [Optional] EBKBHGJMDMP EPIPNOBBMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x428C6F0", Offset = "0x428AEF0", VA = "0x18428C6F0")]
	public Task<TResult> DKHIGLLOPPE(TRequest GPCNCGBOPJG, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x428C490", Offset = "0x428AC90", VA = "0x18428C490")]
	private void BLEEADHCKKC(PFKJFMEHMOJ FOIKNMKKKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x428CED0", Offset = "0x428B6D0", VA = "0x18428CED0")]
	[AsyncStateMachine(typeof(LLNBPHOHMNO<, >.AANEIBFALJN))]
	private Task LICNHNOGJKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x428D900", Offset = "0x428C100", VA = "0x18428D900")]
	private PFKJFMEHMOJ NIHOKLMGKOO()
	{
		return default(PFKJFMEHMOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x428D170", Offset = "0x428B970", VA = "0x18428D170")]
	[AsyncStateMachine(typeof(LLNBPHOHMNO<, >.MLNAIEAFIFE))]
	private Task NBGALBJACNO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x428DCD0", Offset = "0x428C4D0", VA = "0x18428DCD0")]
	private void OLPBGAGFGEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x428CDC0", Offset = "0x428B5C0", VA = "0x18428CDC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class PEGNAEEHKKL<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly List<T> CGIFJALMJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private HashSet<T> KEAGOEBAADJ;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3582930", Offset = "0x3581130", VA = "0x183582930", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool HNPAFAKBDHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x8999F0", VA = "0x18089B1F0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public T NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2748CD0", Offset = "0x27474D0", VA = "0x182748CD0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x475F340", Offset = "0x475DB40", VA = "0x18475F340", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3C1CE30", Offset = "0x3C1B630", VA = "0x183C1CE30", Slot = "11")]
	public void Add(T JNHGHHKKNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x475E970", Offset = "0x475D170", VA = "0x18475E970")]
	public bool AGNJLLJNDOJ(T JNHGHHKKNBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x475F160", Offset = "0x475D960", VA = "0x18475F160", Slot = "15")]
	public bool Remove(T JNHGHHKKNBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3BD7B60", Offset = "0x3BD6360", VA = "0x183BD7B60", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3BF0510", Offset = "0x3BEED10", VA = "0x183BF0510", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x475EA60", Offset = "0x475D260", VA = "0x18475EA60", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x475EB00", Offset = "0x475D300", VA = "0x18475EB00", Slot = "13")]
	public bool Contains(T JNHGHHKKNBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x475EB50", Offset = "0x475D350", VA = "0x18475EB50", Slot = "14")]
	public void CopyTo(T[] PFKJAOOHGBN, int OMHDEOJLLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4202A50", Offset = "0x4201250", VA = "0x184202A50", Slot = "6")]
	public int IndexOf(T JNHGHHKKNBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x475ECE0", Offset = "0x475D4E0", VA = "0x18475ECE0", Slot = "7")]
	public void Insert(int DHNLEFJCEAH, T JNHGHHKKNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x475EF60", Offset = "0x475D760", VA = "0x18475EF60", Slot = "8")]
	public void RemoveAt(int DHNLEFJCEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x475F220", Offset = "0x475DA20", VA = "0x18475F220")]
	public PEGNAEEHKKL()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x21A6A60", Offset = "0x21A5260", VA = "0x1821A6A60")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x68AD000", Offset = "0x68AB800", VA = "0x1868AD000")]
		public SerializedGuid([In] Guid BMIGIGGJPJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x68ACED0", Offset = "0x68AB6D0", VA = "0x1868ACED0")]
		public static SerializedGuid LGEFIKAIAMK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x68ACE60", Offset = "0x68AB660", VA = "0x1868ACE60")]
		public static SerializedGuid IDICMGFIBGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x68ACCF0", Offset = "0x68AB4F0", VA = "0x1868ACCF0")]
		public bool CFHDDGLKNCC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x68ACFD0", Offset = "0x68AB7D0", VA = "0x1868ACFD0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x68ACF50", Offset = "0x68AB750", VA = "0x1868ACF50", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD80", Offset = "0x68AB580", VA = "0x1868ACD80", Slot = "7")]
		public bool Equals(SerializedGuid OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x68ACDC0", Offset = "0x68AB5C0", VA = "0x1868ACDC0", Slot = "0")]
		public override bool Equals(object MEAFIMADMKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x68ACE50", Offset = "0x68AB650", VA = "0x1868ACE50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD50", Offset = "0x68AB550", VA = "0x1868ACD50", Slot = "6")]
		public int CompareTo(SerializedGuid OKGBBGMIACH)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class ONFMOOOPGFJ : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly Type PNKOJBNOJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly string PEDAFBNCNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool HFDNAEDKMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool GDBLJJMDBNI;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x68AB6F0", Offset = "0x68A9EF0", VA = "0x1868AB6F0")]
	public ONFMOOOPGFJ(Type CGDDLPBGNNM, string FBDJFLEOFMI, bool PPHGECCENLH = false, bool GHAEIGGIDIG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class OADONCMLPJG<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public readonly struct CENCABLHMDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly long KLAGOPJFMBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly long HHKEGHFGPEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly int JHAPJJJNDPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly int BPNEAIMIODL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly bool DPKGDAPDGHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly string AHDKPNBDPPD;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5104680", Offset = "0x5102E80", VA = "0x185104680")]
		public CENCABLHMDP(long KLAGOPJFMBH, int JHAPJJJNDPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5104650", Offset = "0x5102E50", VA = "0x185104650")]
		public CENCABLHMDP(long KLAGOPJFMBH, long HHKEGHFGPEN, int JHAPJJJNDPF, int BPNEAIMIODL, bool DPKGDAPDGHN, string AHDKPNBDPPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x51044E0", Offset = "0x5102CE0", VA = "0x1851044E0")]
		public int KDMIGDIIPBB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x51045D0", Offset = "0x5102DD0", VA = "0x1851045D0")]
		public int MBLLJLINFID(int FFLLANCAOFF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x51045F0", Offset = "0x5102DF0", VA = "0x1851045F0")]
		public double PNBHBLKJGEA()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5104530", Offset = "0x5102D30", VA = "0x185104530")]
		public CENCABLHMDP LCENFNDIJHE(long HHKEGHFGPEN, int BPNEAIMIODL)
		{
			return default(CENCABLHMDP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class HILOONJJDHL : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private struct PNBCGELHKKN<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public HILOONJJDHL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Func<HILOONJJDHL, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private HILOONJJDHL <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x4773260", Offset = "0x4771A60", VA = "0x184773260", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x3806840", Offset = "0x3805040", VA = "0x183806840", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly TKey HJDGBLHMFIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly OADONCMLPJG<TKey> GFNLGFOFJFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public readonly CDLNJDLNIPA KBNCOADBJAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private List<HILOONJJDHL> FCJJODHBCHH;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public string AOHCGGKNAML
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x3D19E70", Offset = "0x3D18670", VA = "0x183D19E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public IEnumerable<HILOONJJDHL> PEPBBOEMMMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x3D19C80", Offset = "0x3D18480", VA = "0x183D19C80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public CENCABLHMDP MEJDIPHAJMD
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x3D19EC0", Offset = "0x3D186C0", VA = "0x183D19EC0")]
			[CompilerGenerated]
			get
			{
				return default(CENCABLHMDP);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x3D19A10", Offset = "0x3D18210", VA = "0x183D19A10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3D19EE0", Offset = "0x3D186E0", VA = "0x183D19EE0")]
		internal HILOONJJDHL(OADONCMLPJG<TKey> GFNLGFOFJFM, TKey NDDCLPHCEEO, CDLNJDLNIPA KBNCOADBJAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3D19CC0", Offset = "0x3D184C0", VA = "0x183D19CC0")]
		public HILOONJJDHL FINICLOHGIA(TKey NDDCLPHCEEO, [Optional] CDLNJDLNIPA? BALLFEMFJJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x29D1FF0", Offset = "0x29D07F0", VA = "0x1829D1FF0")]
		[AsyncStateMachine(typeof(PNBCGELHKKN<>))]
		public Task<T> DOCLEABBBAL<T>(TKey NDDCLPHCEEO, Func<HILOONJJDHL, Task<T>> GPJOKKOGGOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3D19A40", Offset = "0x3D18240", VA = "0x183D19A40", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class HPMAGKANJKC : IEnumerable<(TKey, List<TKey>, CENCABLHMDP)>, IEnumerable, IEnumerator<(TKey, List<TKey>, CENCABLHMDP)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private (TKey key, List<TKey> path, CENCABLHMDP timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public OADONCMLPJG<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IEnumerator<(TKey key, List<TKey> path, CENCABLHMDP timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private (TKey, List<TKey>, CENCABLHMDP) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x21A74B0", Offset = "0x21A5CB0", VA = "0x1821A74B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, CENCABLHMDP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x3D54F50", Offset = "0x3D53750", VA = "0x183D54F50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x21A75A0", Offset = "0x21A5DA0", VA = "0x1821A75A0")]
		[DebuggerHidden]
		public HPMAGKANJKC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x3982270", Offset = "0x3980A70", VA = "0x183982270", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3D54A90", Offset = "0x3D53290", VA = "0x183D54A90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3D54A40", Offset = "0x3D53240", VA = "0x183D54A40")]
		private void CEOBCCLIKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3D54F00", Offset = "0x3D53700", VA = "0x183D54F00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3D54E30", Offset = "0x3D53630", VA = "0x183D54E30", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, CENCABLHMDP)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3ADC830", Offset = "0x3ADB030", VA = "0x183ADC830", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class NNLEBBADFID : IEnumerable<(TKey, List<TKey>, CENCABLHMDP)>, IEnumerable, IEnumerator<(TKey, List<TKey>, CENCABLHMDP)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private (TKey key, List<TKey> path, CENCABLHMDP timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private HILOONJJDHL timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public HILOONJJDHL <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public OADONCMLPJG<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private IEnumerator<HILOONJJDHL> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private IEnumerator<(TKey key, List<TKey> path, CENCABLHMDP timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, CENCABLHMDP) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x21A74B0", Offset = "0x21A5CB0", VA = "0x1821A74B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, CENCABLHMDP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x4532D70", Offset = "0x4531570", VA = "0x184532D70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x21A75A0", Offset = "0x21A5DA0", VA = "0x1821A75A0")]
		[DebuggerHidden]
		public NNLEBBADFID(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4532DD0", Offset = "0x45315D0", VA = "0x184532DD0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4532410", Offset = "0x4530C10", VA = "0x184532410", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4532350", Offset = "0x4530B50", VA = "0x184532350")]
		private void CEOBCCLIKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x45323B0", Offset = "0x4530BB0", VA = "0x1845323B0")]
		private void KNPOGHPBEEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4532D20", Offset = "0x4531520", VA = "0x184532D20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x4532BE0", Offset = "0x45313E0", VA = "0x184532BE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, CENCABLHMDP)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x4532CE0", Offset = "0x45314E0", VA = "0x184532CE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly Action<TKey, CENCABLHMDP, CDLNJDLNIPA> CDDNBOKDIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Action<TKey, CENCABLHMDP, CDLNJDLNIPA> DDIKNNBKHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly Action<OADONCMLPJG<TKey>, CDLNJDLNIPA> EBNPBMEGAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly CDLNJDLNIPA KBNCOADBJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly HILOONJJDHL AMFJIPJPHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private bool MAFFMBBADNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int EHLLNMHLGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly Stopwatch FPCPJEPFGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly int MAJPDHANBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string HAFKKLEAJLM;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public HILOONJJDHL FDKCIFMCANG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	[NotNull]
	public string AOHCGGKNAML
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x856300", Offset = "0x854B00", VA = "0x180856300")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4602950", Offset = "0x4601150", VA = "0x184602950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x46029B0", Offset = "0x46011B0", VA = "0x1846029B0")]
	public OADONCMLPJG(TKey PGNFCILIBKB, CDLNJDLNIPA KBNCOADBJAI, [Optional] int? JHAPJJJNDPF, [Optional][CanBeNull] Stopwatch FPCPJEPFGDL, [Optional] Action<TKey, CENCABLHMDP, CDLNJDLNIPA> CDDNBOKDIMA, [Optional] Action<TKey, CENCABLHMDP, CDLNJDLNIPA> DDIKNNBKHHD, [Optional] Action<OADONCMLPJG<TKey>, CDLNJDLNIPA> EBNPBMEGAIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4602880", Offset = "0x4601080", VA = "0x184602880", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x46027E0", Offset = "0x4600FE0", VA = "0x1846027E0")]
	[IteratorStateMachine(typeof(OADONCMLPJG<>.HPMAGKANJKC))]
	public IEnumerable<(TKey, List<TKey>, CENCABLHMDP)> DJMKPDMAODN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4602700", Offset = "0x4600F00", VA = "0x184602700")]
	[IteratorStateMachine(typeof(OADONCMLPJG<>.NNLEBBADFID))]
	private IEnumerable<(TKey, List<TKey>, CENCABLHMDP)> DJMKPDMAODN(List<TKey> BECGFNBELMK, HILOONJJDHL DOAFLGODEDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4602680", Offset = "0x4600E80", VA = "0x184602680")]
	private (long, int) CDBPGJJNNAF()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public abstract class CPKOJAAICCF<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut BMENGJPMPIB(OADONCMLPJG<TKey> GFNLGFOFJFM);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
	protected CPKOJAAICCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public abstract class PJPNOLNCOGB<TKey> : CPKOJAAICCF<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate string AEMENILFDFE(TKey NDDCLPHCEEO);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x476BDD0", Offset = "0x476A5D0", VA = "0x18476BDD0")]
	private static string DJJIKBBNAGO(TKey NDDCLPHCEEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x476BCF0", Offset = "0x476A4F0", VA = "0x18476BCF0", Slot = "4")]
	public override string BMENGJPMPIB(OADONCMLPJG<TKey> GFNLGFOFJFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x476BBA0", Offset = "0x476A3A0", VA = "0x18476BBA0")]
	public string BMENGJPMPIB(OADONCMLPJG<TKey> GFNLGFOFJFM, [NotNull] AEMENILFDFE NBKHPILOMOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string BLLHFJPBMOE(OADONCMLPJG<TKey> GFNLGFOFJFM, [NotNull] AEMENILFDFE NBKHPILOMOL);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3CC0640", Offset = "0x3CBEE40", VA = "0x183CC0640")]
	protected PJPNOLNCOGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class LDBDKGIKPEF<TKey> : CPKOJAAICCF<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public delegate string KGBLOFDDKLH(TKey NDDCLPHCEEO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly string BOONLBHLOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly double GMGPNLBKAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly bool PFAENIKAPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly int BMMMIGBMDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly ISet<string> GOBFALADJGM;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x422B910", Offset = "0x422A110", VA = "0x18422B910")]
	private static string DJJIKBBNAGO(TKey NDDCLPHCEEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x422BBC0", Offset = "0x422A3C0", VA = "0x18422BBC0")]
	public LDBDKGIKPEF(string BOONLBHLOGE = "F2", double GMGPNLBKAOC = double.MaxValue, bool PFAENIKAPLP = false, int BMMMIGBMDLJ = int.MaxValue, [Optional] ISet<string> GOBFALADJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x422B750", Offset = "0x4229F50", VA = "0x18422B750", Slot = "4")]
	public override Dictionary<string, string> BMENGJPMPIB(OADONCMLPJG<TKey> GFNLGFOFJFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x422B830", Offset = "0x422A030", VA = "0x18422B830")]
	private bool CMAKGCDIHIB(string FELMDNOFLBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x422B120", Offset = "0x4229920", VA = "0x18422B120")]
	public Dictionary<string, string> BMENGJPMPIB(OADONCMLPJG<TKey> GFNLGFOFJFM, KGBLOFDDKLH NBKHPILOMOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x422B950", Offset = "0x422A150", VA = "0x18422B950")]
	private string FBLDDIGEKAC(StringBuilder OOBMNIJGKAM, List<TKey> GFLLMHHAMIJ, KGBLOFDDKLH NBKHPILOMOL, bool DCKCCBMBKML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x422AFC0", Offset = "0x42297C0", VA = "0x18422AFC0")]
	private static void BGBBFIIIAGM(StringBuilder KEOPMHJOBBH, string MECMFGBHOOA, bool JPDDEBGGPGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class FKKEPGGADDP<TKey> : PJPNOLNCOGB<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct DEAPGGLMCPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AEMENILFDFE keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static FKKEPGGADDP<TKey> MJFJCBEEADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly string[] ABPHODNPGAH;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3BE5250", Offset = "0x3BE3A50", VA = "0x183BE5250")]
	private FKKEPGGADDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3BE41C0", Offset = "0x3BE29C0", VA = "0x183BE41C0", Slot = "5")]
	protected override string BLLHFJPBMOE(OADONCMLPJG<TKey> GFNLGFOFJFM, AEMENILFDFE NBKHPILOMOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3BE5010", Offset = "0x3BE3810", VA = "0x183BE5010")]
	[CompilerGenerated]
	internal static string CFJJJHFDALF(string FKLCPMENCPL, TKey NDDCLPHCEEO, DEAPGGLMCPA P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class COIHLFMDECC : OADONCMLPJG<string>
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class LJLCLGHGGEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Action<COIHLFMDECC, CDLNJDLNIPA> callback;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public LJLCLGHGGEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x68AB140", Offset = "0x68A9940", VA = "0x1868AB140")]
		internal void AOBJLOGCGCC(OADONCMLPJG<string> timer, CDLNJDLNIPA log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x68A7CD0", Offset = "0x68A64D0", VA = "0x1868A7CD0")]
	public COIHLFMDECC(CDLNJDLNIPA KBNCOADBJAI, [Optional] string NELDGGFCGBO, [Optional] int? JHAPJJJNDPF, [Optional] Stopwatch FPCPJEPFGDL, [Optional] Action<string, CENCABLHMDP, CDLNJDLNIPA> CDDNBOKDIMA, [Optional] Action<string, CENCABLHMDP, CDLNJDLNIPA> DDIKNNBKHHD, [Optional] Action<COIHLFMDECC, CDLNJDLNIPA> EBNPBMEGAIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x68A7C10", Offset = "0x68A6410", VA = "0x1868A7C10")]
	private static Action<OADONCMLPJG<string>, CDLNJDLNIPA> HACHDNNNLLE(Action<COIHLFMDECC, CDLNJDLNIPA> HBBMMHKOEKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class GEKKFPEPFEA
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private class PNLPKPOJFJL : GEKKFPEPFEA
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public static GEKKFPEPFEA MJFJCBEEADM
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x68AB760", Offset = "0x68A9F60", VA = "0x1868AB760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override float AMJPOMIJLKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x98CE80", Offset = "0x98B680", VA = "0x18098CE80", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x68AB860", Offset = "0x68AA060", VA = "0x1868AB860")]
		public PNLPKPOJFJL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static GEKKFPEPFEA FIAHPHAFHGL;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static GEKKFPEPFEA ELIKMDBCIKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x68A9080", Offset = "0x68A7880", VA = "0x1868A9080")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public abstract float AMJPOMIJLKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
	protected GEKKFPEPFEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface IABENFAMAOM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool OJBMAONCMFP
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface GBMNPHMLGKB<T> : IABENFAMAOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	[NotNull]
	Task<T> GJLNBAMLKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	[NotNull]
	MAKKFMNHCEA<T> AOBKCEMGLKF
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class CIBINEPEOEH
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x293B6A0", Offset = "0x2939EA0", VA = "0x18293B6A0")]
	public static GBMNPHMLGKB<TResource> KCLJIOCOKEB<TResource, TId>(this FILEOJEALJN<TId, TResource> MGPCCJLLDAM, TId DKFNFHGODON, [Optional] Func<TId, CancellationToken, Task<TResource>>? FLPMJCBHCGB) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class PDMMMODAIBL
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private sealed class IJINABGMDPL<T> : MDDCCCKDBFD<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override Task<T?> GJLNBAMLKBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override MAKKFMNHCEA<T?> AOBKCEMGLKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8510A0", VA = "0x1808528A0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3EC1E80", Offset = "0x3EC0680", VA = "0x183EC1E80")]
		public IJINABGMDPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "10")]
		protected override void MDIOCFABDCD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private sealed class OEDAMCGCDGP<T> : MDDCCCKDBFD<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly T OBAIELFNFBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly Action<T>? JNKKLOOAFLE;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override Task<T> GJLNBAMLKBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x856960", Offset = "0x855160", VA = "0x180856960", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override MAKKFMNHCEA<T> AOBKCEMGLKF
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x856AB0", Offset = "0x8552B0", VA = "0x180856AB0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x4623370", Offset = "0x4621B70", VA = "0x184623370")]
		public OEDAMCGCDGP(T GDBEHNBLALJ, Action<T>? BDILBDIGJFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x46232C0", Offset = "0x4621AC0", VA = "0x1846232C0", Slot = "10")]
		protected override void MDIOCFABDCD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private sealed class HPCMBIPFBDO<T> : MDDCCCKDBFD<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override Task<T> GJLNBAMLKBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override MAKKFMNHCEA<T> AOBKCEMGLKF
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8510A0", VA = "0x1808528A0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3D53080", Offset = "0x3D51880", VA = "0x183D53080")]
		public HPCMBIPFBDO(Exception HBEPHPNHPNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "10")]
		protected override void MDIOCFABDCD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private sealed class JENNPKJBJKI<T> : MDDCCCKDBFD<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct FIGADIKGLEI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public Task<GBMNPHMLGKB<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private TaskAwaiter<GBMNPHMLGKB<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x3BDB580", Offset = "0x3BD9D80", VA = "0x183BDB580", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x3BDBA80", Offset = "0x3BDA280", VA = "0x183BDBA80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct BKGHLKIEEDI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public Task<GBMNPHMLGKB<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private TaskAwaiter<GBMNPHMLGKB<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x4E2DD20", Offset = "0x4E2C520", VA = "0x184E2DD20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x4E2E180", Offset = "0x4E2C980", VA = "0x184E2E180", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly Task<GBMNPHMLGKB<T>> ABMDBAFOLDA;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override Task<T> GJLNBAMLKBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8510A0", VA = "0x1808528A0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override MAKKFMNHCEA<T> AOBKCEMGLKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x856940", Offset = "0x855140", VA = "0x180856940", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x4093650", Offset = "0x4091E50", VA = "0x184093650")]
		public JENNPKJBJKI(Task<GBMNPHMLGKB<T>> LEDCCMOCHJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x4093530", Offset = "0x4091D30", VA = "0x184093530", Slot = "10")]
		protected override void MDIOCFABDCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x4093210", Offset = "0x4091A10", VA = "0x184093210")]
		[AsyncStateMachine(typeof(JENNPKJBJKI<>.FIGADIKGLEI))]
		[CompilerGenerated]
		internal static Task<T> CPEBEHODMBN(Task<GBMNPHMLGKB<T>> LEDCCMOCHJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x4093370", Offset = "0x4091B70", VA = "0x184093370")]
		[AsyncStateMachine(typeof(JENNPKJBJKI<>.BKGHLKIEEDI))]
		[CompilerGenerated]
		internal static Task MCKOPPOLCGM(Task<GBMNPHMLGKB<T>> LEDCCMOCHJB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private sealed class DNPBNLOHHHF<TIn, TOut> : MDDCCCKDBFD<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct LOAPPFFINDE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public AsyncTaskMethodBuilder<TOut> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public Func<TIn, TOut> transformFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public Task<TIn> innerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private Func<TIn, TOut> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private TaskAwaiter<TIn> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x4294B90", Offset = "0x4293390", VA = "0x184294B90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x3C55490", Offset = "0x3C53C90", VA = "0x183C55490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly GBMNPHMLGKB<TIn> GPFBODKIOAJ;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override Task<TOut> GJLNBAMLKBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8510A0", VA = "0x1808528A0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override MAKKFMNHCEA<TOut> AOBKCEMGLKF
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x856940", Offset = "0x855140", VA = "0x180856940", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x57783B0", Offset = "0x5776BB0", VA = "0x1857783B0")]
		public DNPBNLOHHHF(GBMNPHMLGKB<TIn> BIPHMNOOLAG, Func<TIn, TOut> AMBLFAKGKHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x5778360", Offset = "0x5776B60", VA = "0x185778360", Slot = "10")]
		protected override void MDIOCFABDCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5778010", Offset = "0x5776810", VA = "0x185778010")]
		[AsyncStateMachine(typeof(DNPBNLOHHHF<, >.LOAPPFFINDE))]
		[CompilerGenerated]
		internal static Task<TOut> HOHFKGAHFIN(Task<TIn> DJMMIEKABGF, Func<TIn, TOut> AMBLFAKGKHE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2CC5AA0", Offset = "0x2CC42A0", VA = "0x182CC5AA0")]
	public static GBMNPHMLGKB<T> ENKECPBOOIC<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2CC59F0", Offset = "0x2CC41F0", VA = "0x182CC59F0")]
	public static GBMNPHMLGKB<T> CPNDOIMICJM<T>(T ADPMAHMCGNH, [Optional] Action<T>? BDILBDIGJFD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x2B5FF50", Offset = "0x2B5E750", VA = "0x182B5FF50")]
	public static GBMNPHMLGKB<T> HJMCIEPGHOP<T>(Exception HBEPHPNHPNB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x2B5FF50", Offset = "0x2B5E750", VA = "0x182B5FF50")]
	public static GBMNPHMLGKB<T> LPMMIMKFOPJ<T>(Task<GBMNPHMLGKB<T>> LEDCCMOCHJB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x28C7750", Offset = "0x28C5F50", VA = "0x1828C7750")]
	public static GBMNPHMLGKB<TOut> IKKMMCBJHKI<TOut, TIn>(GBMNPHMLGKB<TIn> IIMJMBJHGDI, Func<TIn, TOut> AMBLFAKGKHE) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public abstract class MDDCCCKDBFD<T> : GBMNPHMLGKB<T>, IABENFAMAOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static readonly string LBMPEFBEIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly AHNPDBJIDJD OGOPNLCHEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private bool MAFFMBBADNE;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool OJBMAONCMFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xB7F4B0", Offset = "0xB7DCB0", VA = "0x180B7F4B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public abstract Task<T> GJLNBAMLKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public abstract MAKKFMNHCEA<T> AOBKCEMGLKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x447D7F0", Offset = "0x447BFF0", VA = "0x18447D7F0")]
	public MDDCCCKDBFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x447D3F0", Offset = "0x447BBF0", VA = "0x18447D3F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void MDIOCFABDCD();
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public abstract class OBLJHNCCPPP<TTask, T> : MDDCCCKDBFD<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class NEBGBHFDEIJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public NEBGBHFDEIJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x3570610", Offset = "0x356EE10", VA = "0x183570610", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x3570B60", Offset = "0x356F360", VA = "0x183570B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public OBLJHNCCPPP<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public NEBGBHFDEIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x44FEE70", Offset = "0x44FD670", VA = "0x1844FEE70")]
		[AsyncStateMachine(typeof(OBLJHNCCPPP<, >.NEBGBHFDEIJ.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> ECDKOFADJJG(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly Task<T> LEDCCMOCHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	protected readonly CancellationTokenSource NPCICLIMLAO;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public override Task<T> GJLNBAMLKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public override MAKKFMNHCEA<T> AOBKCEMGLKF
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8510A0", VA = "0x1808528A0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x460B9D0", Offset = "0x460A1D0", VA = "0x18460B9D0")]
	protected OBLJHNCCPPP(TTask LEDCCMOCHJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x460B790", Offset = "0x4609F90", VA = "0x18460B790", Slot = "10")]
	protected override void MDIOCFABDCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T DOCHOJKICPF(TTask OMBNLOMPPEF);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void GLGFOCIIMBB();
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class GNFMNOLIFHP<T> : MDDCCCKDBFD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly PIKIJNPLMPM<Task<T>> KNGNJJGKNLA;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public override Task<T> GJLNBAMLKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3CD1580", Offset = "0x3CCFD80", VA = "0x183CD1580", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public override MAKKFMNHCEA<T> AOBKCEMGLKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8510A0", VA = "0x1808528A0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3CD15F0", Offset = "0x3CCFDF0", VA = "0x183CD15F0")]
	public GNFMNOLIFHP(PIKIJNPLMPM<Task<T>> FOFGABHMNDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3CD15D0", Offset = "0x3CCFDD0", VA = "0x183CD15D0", Slot = "10")]
	protected override void MDIOCFABDCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class LHFAHALCBEB
{
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public static readonly HashAlgorithmName OGCCNNILNND;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly ThreadLocal<IncrementalHash> CMMFHCKDAGP;

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x68AA840", Offset = "0x68A9040", VA = "0x1868AA840")]
	public static int EOPENGOEFIE(this CEAGNJHJOCG PFNNOMPNEPO, IncrementalHash BGMAOMLOOIC, byte[] DDKJPDFNFFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x68AAC80", Offset = "0x68A9480", VA = "0x1868AAC80")]
	public static bool OCCAPKCOBAG([CanBeNull] this CEAGNJHJOCG PFNNOMPNEPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x68AACE0", Offset = "0x68A94E0", VA = "0x1868AACE0")]
	public static bool OCCAPKCOBAG([CanBeNull] this CEAGNJHJOCG PFNNOMPNEPO, [Out] string GGEHLADLJHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x68AA950", Offset = "0x68A9150", VA = "0x1868AA950")]
	public static bool OCCAPKCOBAG([CanBeNull] this CEAGNJHJOCG PFNNOMPNEPO, IncrementalHash BGMAOMLOOIC, byte[] DDKJPDFNFFD, [Out] string GGEHLADLJHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x68AA8C0", Offset = "0x68A90C0", VA = "0x1868AA8C0")]
	private static bool MPGJNMPBAJG(byte[] OMFLMICADGH, Span<byte> EBICLIKEKJG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class LHDMLOIIAOF
{
	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x68AA6F0", Offset = "0x68A8EF0", VA = "0x1868AA6F0")]
	public static int IPKIPJBEPHJ(HashAlgorithmName MNIMKJCKKKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x68AA490", Offset = "0x68A8C90", VA = "0x1868AA490")]
	public static int EOPENGOEFIE(this FOEMIFIPDHC DHFJKIPBMFJ, byte[] NMFEPCIMIAN, IncrementalHash BGMAOMLOOIC, byte[] EKFMIPDOAPN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface FOEMIFIPDHC
{
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash BGMAOMLOOIC);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface CEAGNJHJOCG : FOEMIFIPDHC
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	[CanBeNull]
	byte[] FAKBFMBEEFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	[CanBeNull]
	byte[] AAHKDJIIEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class IOJCOBHAGFG
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static bool MMALCHFILNB;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly ArrayPool<byte> LFJOBHFHLIP;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly ArrayPool<char> KPHKJMHODKM;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly Encoding BAKLFFLKPIP;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly ThreadLocal<Encoder> EEOPNEOPEBO;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2BAE340", Offset = "0x2BACB40", VA = "0x182BAE340")]
	public static void CNPAGKBBIPD<T>(this IncrementalHash EJJPKIEAEOJ, [CanBeNull] T INPAFGCEBHH) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2BAEA30", Offset = "0x2BAD230", VA = "0x182BAEA30")]
	public static void EMLEKPEKODA<T>(this IncrementalHash EJJPKIEAEOJ, [CanBeNull] T DHFJKIPBMFJ) where T : FOEMIFIPDHC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2BAEAC0", Offset = "0x2BAD2C0", VA = "0x182BAEAC0")]
	public static void KDEPAHFAJNG<T>(this IncrementalHash EJJPKIEAEOJ, [CanBeNull] IList<T> AMPDPODCKNI) where T : FOEMIFIPDHC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x68A9A00", Offset = "0x68A8200", VA = "0x1868A9A00")]
	private static bool HOEIECHNKHJ([CanBeNull] FOEMIFIPDHC DHFJKIPBMFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x68A9CC0", Offset = "0x68A84C0", VA = "0x1868A9CC0")]
	public static void LCFNAEKCBPL(this IncrementalHash BGMAOMLOOIC, string? OCIBELDMAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x68A9660", Offset = "0x68A7E60", VA = "0x1868A9660")]
	public static void FKEGCHJGIOJ(this IncrementalHash BGMAOMLOOIC, long GFMBFOEFLFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x68A9830", Offset = "0x68A8030", VA = "0x1868A9830")]
	public static void GBNCLGONELP(this IncrementalHash BGMAOMLOOIC, int EOHIGKOGJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x68A91F0", Offset = "0x68A79F0", VA = "0x1868A91F0")]
	public static void DJAPLPKGNGB(this IncrementalHash BGMAOMLOOIC, short EKIDBNIHGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x68A9550", Offset = "0x68A7D50", VA = "0x1868A9550")]
	public static void FGLNHDMIGKO(this IncrementalHash BGMAOMLOOIC, byte LGAPMFOONIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x68A9A90", Offset = "0x68A8290", VA = "0x1868A9A90")]
	public static void KNKOIFFHJAH(this IncrementalHash BGMAOMLOOIC, bool JGCDIGHDPJC, bool NFCMLGILAOO = false, bool ADPDFKGHKGK = false, bool LEPLIIGEKNE = false, bool INAJHEFHAGB = false, bool MGFEEBHGLDK = false, bool GNEMENOMHLN = false, bool DNHAFAKMNCK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2BAE400", Offset = "0x2BACC00", VA = "0x182BAE400")]
	public static void DLLAPPKCHBA<T>(this IncrementalHash BGMAOMLOOIC, T NKEPPGPEFAC) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x68A93C0", Offset = "0x68A7BC0", VA = "0x1868A93C0")]
	public static void EEPLLLFEHPA(this IncrementalHash BGMAOMLOOIC, float CGKCMNEGKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x68A9C60", Offset = "0x68A8460", VA = "0x1868A9C60")]
	public static void LCEEFBMDLNC(this IncrementalHash BGMAOMLOOIC, ulong HIDLCCHGKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x68A9C00", Offset = "0x68A8400", VA = "0x1868A9C00")]
	public static void KOIGCEAPDPH(this IncrementalHash BGMAOMLOOIC, uint JGPNPJAIALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x68AA0D0", Offset = "0x68A88D0", VA = "0x1868AA0D0")]
	public static void LGDCCFKHDAM(this IncrementalHash BGMAOMLOOIC, ushort NFMGAKDNKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x68A9420", Offset = "0x68A7C20", VA = "0x1868A9420")]
	public static void FCIPJKPKEKP(this IncrementalHash BGMAOMLOOIC, Vector3 NLCKJNGAHOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class EOCGBMKNDDN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x68A8FA0", Offset = "0x68A77A0", VA = "0x1868A8FA0")]
	public EOCGBMKNDDN(string JNNDBFGKHHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public abstract class OLMGKNKHOEA<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	internal class JGFNDJBHLGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public TNode HIKEOGPAJAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public TNode BMBBFJPOJEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public MKNIGIHFOCE IDOOJPJNKLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public List<MKNIGIHFOCE> MEBIICEPBCE;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public JGFNDJBHLGK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	internal struct MKNIGIHFOCE : IComparable<MKNIGIHFOCE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public int CBHPEKJLLAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public TClaimant JOOMFCKIBIA;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xD87910", Offset = "0xD86110", VA = "0x180D87910")]
		public MKNIGIHFOCE(int CBHPEKJLLAF, TClaimant JOOMFCKIBIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x44992B0", Offset = "0x4497AB0", VA = "0x1844992B0")]
		public bool GLMODKNLDMJ([In] MKNIGIHFOCE OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x4499310", Offset = "0x4497B10", VA = "0x184499310")]
		public bool JFCICOEJFHD([In] MKNIGIHFOCE OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x44992A0", Offset = "0x4497AA0", VA = "0x1844992A0", Slot = "4")]
		public int CompareTo(MKNIGIHFOCE OKGBBGMIACH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x4499320", Offset = "0x4497B20", VA = "0x184499320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public enum CEBFEKJKDCN
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class PMNNDINKMBK : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public OLMGKNKHOEA<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x89FD00", Offset = "0x89E500", VA = "0x18089FD00")]
		[DebuggerHidden]
		public PMNNDINKMBK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x4772E40", Offset = "0x4771640", VA = "0x184772E40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4773010", Offset = "0x4771810", VA = "0x184773010", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x4772F20", Offset = "0x4771720", VA = "0x184772F20", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3983840", Offset = "0x3982040", VA = "0x183983840", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly CAJPHPCFPPJ<JGFNDJBHLGK> GOHLDHFINAI;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly CAJPHPCFPPJ<List<MKNIGIHFOCE>> AKBNLJNBMGA;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static int ELDDLGIECEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	internal readonly Dictionary<TClaimant, TNode> EOPOIOIBAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	internal readonly Dictionary<TNode, JGFNDJBHLGK> DMGOLBKMDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private CEBFEKJKDCN DNCAOAEPAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool LOOMHHLOKGF;

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode EJGCADKFNOA(TNode LLENHGPBNOK);

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void JPPKKMPMPEF(TNode LLENHGPBNOK, TClaimant FFJFCDDDHHD, TClaimant POAGJKNBNPJ);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x46690F0", Offset = "0x46678F0", VA = "0x1846690F0")]
	public OLMGKNKHOEA(CEBFEKJKDCN DNCAOAEPAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x4668E60", Offset = "0x4667660", VA = "0x184668E60")]
	public void NJJNMEDKCPE(TNode LLENHGPBNOK, TNode KGHLFFBGAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x4667EB0", Offset = "0x46666B0", VA = "0x184667EB0")]
	public void FPDLNKKCFJK(TClaimant JOOMFCKIBIA, TNode LHEKFIAPFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x4667BA0", Offset = "0x46663A0", VA = "0x184667BA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x46684D0", Offset = "0x4666CD0", VA = "0x1846684D0")]
	private void LHDCOHMHHHG(TClaimant JOOMFCKIBIA, TNode OOOGHEGGLNM, TNode LHEKFIAPFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x4668020", Offset = "0x4666820", VA = "0x184668020")]
	private int GMKIELAOLGB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x46689C0", Offset = "0x46671C0", VA = "0x1846689C0")]
	private void MOBFJOJEODO(TClaimant JOOMFCKIBIA, TNode BIAKJJCLLID, TNode MODLHPADBNH, int JJCEFAGICFP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x46688F0", Offset = "0x46670F0", VA = "0x1846688F0")]
	private void MLAPOHICBNJ(MKNIGIHFOCE PPMAMEOGFHI, JGFNDJBHLGK EGLLCDAKFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x4667630", Offset = "0x4665E30", VA = "0x184667630")]
	private void BJMICDOBFJM(TClaimant JOOMFCKIBIA, TNode BIAKJJCLLID, TNode MODLHPADBNH, int JJCEFAGICFP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x4667A70", Offset = "0x4666270", VA = "0x184667A70")]
	private void DBOPOABIABA(MKNIGIHFOCE PPMAMEOGFHI, TNode LLENHGPBNOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x4668D00", Offset = "0x4667500", VA = "0x184668D00")]
	private void NAKPKGILFEG(MKNIGIHFOCE PPMAMEOGFHI, JGFNDJBHLGK EGLLCDAKFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x4667920", Offset = "0x4666120", VA = "0x184667920")]
	private void CNDGLHIGANH(JGFNDJBHLGK EGLLCDAKFDC, bool PKNHKGDKIOM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x46685A0", Offset = "0x4666DA0", VA = "0x1846685A0")]
	private void MGKIDAKOLDC(JGFNDJBHLGK EGLLCDAKFDC, TNode KGHLFFBGAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x4668090", Offset = "0x4666890", VA = "0x184668090")]
	[IteratorStateMachine(typeof(OLMGKNKHOEA<, >.PMNNDINKMBK))]
	private IEnumerable<TNode> IHCDNCHFMJE(TNode BIAKJJCLLID, TNode MODLHPADBNH, bool NNLPMCHFPHJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x4667DA0", Offset = "0x46665A0", VA = "0x184667DA0")]
	private JGFNDJBHLGK EHEAPGIABLG(TNode LLENHGPBNOK, TNode BMBBFJPOJEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x4668180", Offset = "0x4666980", VA = "0x184668180")]
	private JGFNDJBHLGK IMNJPKNAEMO(TNode LLENHGPBNOK, TNode BMBBFJPOJEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x4668310", Offset = "0x4666B10", VA = "0x184668310")]
	private void KNIMKAMBEDB(JGFNDJBHLGK EGLLCDAKFDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class DLCLPGKFPDM<T> : IEnumerable<DLCLPGKFPDM<T>.OBDEHHJCNBO>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct OBDEHHJCNBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public T JMDCGOKJIDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public int DHNLEFJCEAH;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class NBGIDHOAPIM : IEnumerator<OBDEHHJCNBO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private DLCLPGKFPDM<T> NAOKJFLCLAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int DHNLEFJCEAH;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x380DDA0", Offset = "0x380C5A0", VA = "0x18380DDA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public OBDEHHJCNBO EBFPDFJFKPC
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x44F90F0", Offset = "0x44F78F0", VA = "0x1844F90F0", Slot = "4")]
			get
			{
				return default(OBDEHHJCNBO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x44F9000", Offset = "0x44F7800", VA = "0x1844F9000")]
		public NBGIDHOAPIM(DLCLPGKFPDM<T> NAOKJFLCLAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x44F8F80", Offset = "0x44F7780", VA = "0x1844F8F80", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x38650D0", Offset = "0x38638D0", VA = "0x1838650D0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x939E00", Offset = "0x938600", VA = "0x180939E00", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private struct NOFLDIHKDIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool DLHNOLAFDOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public T JMDCGOKJIDA;
	}

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private const int PNEGAMBKAPP = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly Dictionary<T, int> IBAMAMICCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private NOFLDIHKDIC[] IHCMEBBLIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private int GNMDMHIJCOI;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public int IOIECPABLEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x891F80", Offset = "0x890780", VA = "0x180891F80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x891580", Offset = "0x88FD80", VA = "0x180891580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3582930", Offset = "0x3581130", VA = "0x183582930")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x5770640", Offset = "0x576EE40", VA = "0x185770640")]
	public DLCLPGKFPDM(int HHGNDILCLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x5770730", Offset = "0x576EF30", VA = "0x185770730")]
	public DLCLPGKFPDM(OBDEHHJCNBO[] LMPEAEHMIBH, bool HLDKFPLAGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x5770170", Offset = "0x576E970", VA = "0x185770170")]
	public int EGHBGNMNINA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x576FD70", Offset = "0x576E570", VA = "0x18576FD70")]
	private int BCNIOLPGFFI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x57703F0", Offset = "0x576EBF0", VA = "0x1857703F0", Slot = "6")]
	protected virtual uint MNAKOEMGGBL(uint BGMAOMLOOIC, T JMDCGOKJIDA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x5770410", Offset = "0x576EC10", VA = "0x185770410")]
	public bool ODHBLCILLBD(T JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x57702C0", Offset = "0x576EAC0", VA = "0x1857702C0")]
	public int ICKPOHFJOGL(T JMDCGOKJIDA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x57704E0", Offset = "0x576ECE0", VA = "0x1857704E0")]
	public T POIMHEEJLCG(int DHNLEFJCEAH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x576FAB0", Offset = "0x576E2B0", VA = "0x18576FAB0")]
	public bool AGNJLLJNDOJ(T JMDCGOKJIDA, bool JJAIHJFGNCD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x576FB10", Offset = "0x576E310", VA = "0x18576FB10")]
	public bool AGNJLLJNDOJ(T JMDCGOKJIDA, int DHNLEFJCEAH, bool JJAIHJFGNCD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5770220", Offset = "0x576EA20", VA = "0x185770220")]
	private int HLIPIGFOOOI(int JHEGPJBDKAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x57705A0", Offset = "0x576EDA0", VA = "0x1857705A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x57705A0", Offset = "0x576EDA0", VA = "0x1857705A0", Slot = "4")]
	private IEnumerator<OBDEHHJCNBO> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class CAJPHPCFPPJ<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly Stack<T> JOPKJIBCCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly List<T> BNAFAHMPPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly int KJLEDNHKEND;

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x5016EF0", Offset = "0x50156F0", VA = "0x185016EF0")]
	public static CAJPHPCFPPJ<T> HBPMPABLDNC(int HHGNDILCLEE = 0, int KJLEDNHKEND = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x5016C40", Offset = "0x5015440", VA = "0x185016C40")]
	public static CAJPHPCFPPJ<T> BJHJLAFEIHL(int HHGNDILCLEE = 0, int KJLEDNHKEND = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x5017740", Offset = "0x5015F40", VA = "0x185017740")]
	public CAJPHPCFPPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x5017540", Offset = "0x5015D40", VA = "0x185017540")]
	public CAJPHPCFPPJ(int HHGNDILCLEE, int KJLEDNHKEND = int.MaxValue, bool BBFPOCCEHDH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x50172D0", Offset = "0x5015AD0", VA = "0x1850172D0")]
	public T MCBLJONGBGM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x5017470", Offset = "0x5015C70", VA = "0x185017470")]
	public void NLCHOINDCPP(T JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x50171D0", Offset = "0x50159D0", VA = "0x1850171D0")]
	private void KDIBJKFCPKI(T JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x5016D30", Offset = "0x5015530", VA = "0x185016D30")]
	private void CAPMIAOOFKN(T JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x5016D70", Offset = "0x5015570", VA = "0x185016D70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x5016FE0", Offset = "0x50157E0", VA = "0x185016FE0")]
	private void IJHCHEHDLAP(IEnumerable<T> MNHECFLLMJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class MEOFAFIIODC<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private Dictionary<int, T> ENCKOMKBEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private T BGCICGMELIJ;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public virtual T MDNMGILJJDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x852890", Offset = "0x851090", VA = "0x180852890", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x448D7A0", Offset = "0x448BFA0", VA = "0x18448D7A0")]
	public bool MBCOGGKHPPK(T JMDCGOKJIDA, int CBHPEKJLLAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x448D8E0", Offset = "0x448C0E0", VA = "0x18448D8E0")]
	public bool NOOCMPIIMHF(int CBHPEKJLLAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x448D3A0", Offset = "0x448BBA0", VA = "0x18448D3A0")]
	public T HDKIBNHBHBG(int EFAIDKFIHBO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x448D1B0", Offset = "0x448B9B0", VA = "0x18448D1B0")]
	private bool BCHEJMABEAA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x448D150", Offset = "0x448B950", VA = "0x18448D150")]
	public bool AKPHPFIGELN(int CBHPEKJLLAF, [Out] T JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x448D980", Offset = "0x448C180", VA = "0x18448D980")]
	public MEOFAFIIODC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class FJGCBIBHNKC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	protected struct CICOHLCPCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public T JNHPIMBJPMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public int CLMJDMFGEEH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	protected readonly List<CICOHLCPCCM> GOKDLEPEPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private T FLCFFHCGPAE;

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3582930", Offset = "0x3581130", VA = "0x183582930")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x3BDE150", Offset = "0x3BDC950", VA = "0x183BDE150")]
	public bool DJONJHALGBO(T JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x3BDEAD0", Offset = "0x3BDD2D0", VA = "0x183BDEAD0")]
	public void PBLNBBGFGAP(T JMDCGOKJIDA, int CBHPEKJLLAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x3BDE570", Offset = "0x3BDCD70", VA = "0x183BDE570")]
	public bool MFKDEBIIBOM(T JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x3BDE4E0", Offset = "0x3BDCCE0", VA = "0x183BDE4E0")]
	public void IMJJLGNDCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x3BDE960", Offset = "0x3BDD160", VA = "0x183BDE960")]
	public T NIPDGGIOLFB()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x3BDDFE0", Offset = "0x3BDC7E0", VA = "0x183BDDFE0")]
	protected void ADIMLGACIJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x3BDEB80", Offset = "0x3BDD380", VA = "0x183BDEB80")]
	public FJGCBIBHNKC()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		[SerializeField]
		[CIHMDBDDPOM(LEHCEJJDOON.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x68AB9F0", Offset = "0x68AA1F0", VA = "0x1868AB9F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x68ABCC0", Offset = "0x68AA4C0", VA = "0x1868ABCC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x68ABBD0", Offset = "0x68AA3D0", VA = "0x1868ABBD0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x68AB940", Offset = "0x68AA140", VA = "0x1868AB940")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x68ABC10", Offset = "0x68AA410", VA = "0x1868ABC10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x68ABB20", Offset = "0x68AA320", VA = "0x1868ABB20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x68AB8B0", Offset = "0x68AA0B0", VA = "0x1868AB8B0")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x491B620", Offset = "0x4919E20", VA = "0x18491B620", Slot = "4")]
		public virtual T IAEKFCIDOJB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class EBAAHAJOGPG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private Dictionary<byte, MGEHJFADNFP> LGFHDKPHDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly CAJPHPCFPPJ<MGEHJFADNFP> KMBEOJJMKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly bool FHFADMIJKPL;

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public MGEHJFADNFP KMOCFMJFNDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851900", VA = "0x180853100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x8530F0", Offset = "0x8518F0", VA = "0x1808530F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Vector2 PFIPJEJHIMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xD31ED0", Offset = "0xD306D0", VA = "0x180D31ED0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x100EA70", Offset = "0x100D270", VA = "0x18100EA70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private Vector2 OIJAPFHDMJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x10742F0", Offset = "0x1072AF0", VA = "0x1810742F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Vector2 KNABPCAPIKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x68A8790", Offset = "0x68A6F90", VA = "0x1868A8790")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x856970", Offset = "0x855170", VA = "0x180856970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public int BBDCOONMEKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x858FA0", Offset = "0x8577A0", VA = "0x180858FA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x858FB0", Offset = "0x8577B0", VA = "0x180858FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x68A8EE0", Offset = "0x68A76E0", VA = "0x1868A8EE0")]
	public EBAAHAJOGPG(Bounds KDCDOPFLHCB, Vector2[] DPJEDCJKKHP, int OJLNBIJKHHG, byte JHEGPJBDKAJ, float GGJDPDBKJBO = 0f, [Optional] CAJPHPCFPPJ<MGEHJFADNFP> KMBEOJJMKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x68A8140", Offset = "0x68A6940", VA = "0x1868A8140")]
	public void BOBCJIHEMLL(Bounds KDCDOPFLHCB, Vector2[] DPJEDCJKKHP, int OJLNBIJKHHG, byte JHEGPJBDKAJ, float GGJDPDBKJBO = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x68A87B0", Offset = "0x68A6FB0", VA = "0x1868A87B0")]
	public MGEHJFADNFP MMNLJMABFJA(byte DHNLEFJCEAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x68A86C0", Offset = "0x68A6EC0", VA = "0x1868A86C0")]
	public void JGKPHFDIMOO(Vector3 HGDCPNGLIKJ, float NANONHKFLNA, float AAJMFKMAPJC, List<byte> KCPGCDNJEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x68A8640", Offset = "0x68A6E40", VA = "0x1868A8640")]
	public void FFGCPAEENBJ(MGEHJFADNFP.LHPOGDFGOMM MPLMFILGECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x68A8DF0", Offset = "0x68A75F0", VA = "0x1868A8DF0")]
	public static int PJBEALCPOAM(Vector2[] DPJEDCJKKHP, int OJLNBIJKHHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x68A8BC0", Offset = "0x68A73C0", VA = "0x1868A8BC0")]
	private MGEHJFADNFP PGDKNGDEEDJ(byte DHNLEFJCEAH, MGEHJFADNFP.BKCIFIMDGNF CNKALIILKAB, MGEHJFADNFP BMBBFJPOJEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x68A8810", Offset = "0x68A7010", VA = "0x1868A8810")]
	private void MPDBJPKFCLE(MGEHJFADNFP BMBBFJPOJEB, Vector2[] DPJEDCJKKHP, int POFJHEANJLB, int HBFHNOFLBKI, int OEDKEGLIMMN, int BCOADEPLLJB, float GGJDPDBKJBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x68A7F20", Offset = "0x68A6720", VA = "0x1868A7F20")]
	private void AKODCACBFNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x68A85E0", Offset = "0x68A6DE0", VA = "0x1868A85E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x68A8660", Offset = "0x68A6E60", VA = "0x1868A8660", Slot = "1")]
	~EBAAHAJOGPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class MGEHJFADNFP
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public enum BKCIFIMDGNF
	{
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public enum LHPOGDFGOMM
	{
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public byte CODEDOIEGGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public Vector3 KNFHACNBEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public Vector3 LIFKLMGEOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public Vector3 KNPEIHDJEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public Vector3 ECFANLHEHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public BKCIFIMDGNF KAMHFFBHMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public MGEHJFADNFP EJAGAMOLJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public List<MGEHJFADNFP> KHBCKHOINMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public bool JOLMKCABECH;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x68AB650", Offset = "0x68A9E50", VA = "0x1868AB650")]
	public MGEHJFADNFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x68AB4F0", Offset = "0x68A9CF0", VA = "0x1868AB4F0")]
	public void LGJHIGDGICA(MGEHJFADNFP JPEFLCPGHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
	public void FFGCPAEENBJ(int DBBMHIGAALB, LHPOGDFGOMM MPLMFILGECK, int GHDPCBMOFPP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x68AB290", Offset = "0x68A9A90", VA = "0x1868AB290")]
	public void JGKPHFDIMOO(List<byte> KCPGCDNJEHA, Vector3 HGDCPNGLIKJ, float NANONHKFLNA, float AAJMFKMAPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x68AB1D0", Offset = "0x68A99D0", VA = "0x1868AB1D0")]
	public bool ENOABKCMGKL(Vector3 FNIJIKICPBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x68AB620", Offset = "0x68A9E20", VA = "0x1868AB620")]
	public bool MMLCMIOAFMM(Vector3 FNIJIKICPBL, float LIOGGACPGOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x68AB200", Offset = "0x68A9A00", VA = "0x1868AB200")]
	public void HMCGAKKBHMB()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public struct NNPHAGBPNDM<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			private readonly List<Component> CGIFJALMJMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			private readonly bool AEJPJHFLJPH;

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x4221860", Offset = "0x4220060", VA = "0x184221860")]
			public NNPHAGBPNDM(List<Component> CGIFJALMJMI, bool AEJPJHFLJPH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x4538D20", Offset = "0x4537520", VA = "0x184538D20")]
			public JJBLGBDCGNE<T> DCPEOMEKOMK()
			{
				return default(JJBLGBDCGNE<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x4538D80", Offset = "0x4537580", VA = "0x184538D80", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x4538D80", Offset = "0x4537580", VA = "0x184538D80", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		public struct JJBLGBDCGNE<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			private readonly List<Component> CGIFJALMJMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private readonly bool AEJPJHFLJPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private int DHNLEFJCEAH;

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public T EBFPDFJFKPC
			{
				[Cpp2IlInjected.Token(Token = "0x6000211")]
				[Cpp2IlInjected.Address(RVA = "0x40A0790", Offset = "0x409EF90", VA = "0x1840A0790", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000212")]
				[Cpp2IlInjected.Address(RVA = "0x40A0720", Offset = "0x409EF20", VA = "0x1840A0720", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x40A0760", Offset = "0x409EF60", VA = "0x1840A0760")]
			public JJBLGBDCGNE(List<Component> CGIFJALMJMI, bool AEJPJHFLJPH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x40A0660", Offset = "0x409EE60", VA = "0x1840A0660", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x40A0670", Offset = "0x409EE70", VA = "0x1840A0670", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x38564F0", Offset = "0x3854CF0", VA = "0x1838564F0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x68AD710", Offset = "0x68ABF10", VA = "0x1868AD710")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x68AD1C0", Offset = "0x68AB9C0", VA = "0x1868AD1C0")]
		private void HMCGAKKBHMB(GameObject JDNAMEBBFMB, bool AMNFMCIBNPO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x68AD130", Offset = "0x68AB930", VA = "0x1868AD130")]
		public static void HMCGAKKBHMB(GameObject JDNAMEBBFMB, ToolHierarchyCache MGPCCJLLDAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x68AD030", Offset = "0x68AB830", VA = "0x1868AD030")]
		public void EKBFOMDGHMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x2E389C0", Offset = "0x2E371C0", VA = "0x182E389C0")]
		public void LEBBJHKNBKL<T>(Action<T> ENGMCBPHJGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x2E38920", Offset = "0x2E37120", VA = "0x182E38920")]
		public T IMHGJJDCNHN<T>(bool AEJPJHFLJPH = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2E38BF0", Offset = "0x2E373F0", VA = "0x182E38BF0")]
		public NNPHAGBPNDM<T> NHGLAGFMEFC<T>(bool AEJPJHFLJPH = false) where T : class
		{
			return default(NNPHAGBPNDM<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x68AD330", Offset = "0x68ABB30", VA = "0x1868AD330")]
		public List<Component> JLPJGPOMMPK(Type NCMHJNKFAGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x68AD040", Offset = "0x68AB840", VA = "0x1868AD040", Slot = "4")]
		public bool Equals(ToolHierarchyCache IPBJLCONKPC, ToolHierarchyCache FACAKAOOAJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x68AD0C0", Offset = "0x68AB8C0", VA = "0x1868AD0C0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache MEAFIMADMKA)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class DKAOIPEKHDK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int HHGNDILCLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int GPLPBBELLMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private List<T> DBMHCDPGPKD;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x3CD1580", Offset = "0x3CCFD80", VA = "0x183CD1580")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public T NCDLNIPPHPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x576B3C0", Offset = "0x5769BC0", VA = "0x18576B3C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public T OAIJJFKKBFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x576B190", Offset = "0x5769990", VA = "0x18576B190")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public T AOELINJOHCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x576B5C0", Offset = "0x5769DC0", VA = "0x18576B5C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x576B8F0", Offset = "0x576A0F0", VA = "0x18576B8F0")]
	public DKAOIPEKHDK(int HHGNDILCLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x576B790", Offset = "0x5769F90", VA = "0x18576B790")]
	public void PBLNBBGFGAP(T NJICNCJNFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x576B300", Offset = "0x5769B00", VA = "0x18576B300")]
	public void IMJJLGNDCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x576B210", Offset = "0x5769A10", VA = "0x18576B210")]
	public void EELNHPMEPEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x576B360", Offset = "0x5769B60", VA = "0x18576B360")]
	public void JPGLPONFFLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x576B110", Offset = "0x5769910", VA = "0x18576B110")]
	public void ALCHLDCDNCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class PAOCFNIHNOE<T>
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private struct FPAKJFKIPKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public int CLMJDMFGEEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public T JNHPIMBJPMJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly Dictionary<object, FPAKJFKIPKF> ENCKOMKBEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly EqualityComparer<T> PLDPEIBNFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private T BGCICGMELIJ;

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public virtual T MDNMGILJJDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x8C9DC0", Offset = "0x8C85C0", VA = "0x1808C9DC0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x4740B20", Offset = "0x473F320", VA = "0x184740B20", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool BFKHAPKIPIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x4740AB0", Offset = "0x473F2B0", VA = "0x184740AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public object ELFAFEKBGJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x85B4C0", Offset = "0x859CC0", VA = "0x18085B4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x4741510", Offset = "0x473FD10", VA = "0x184741510")]
	public bool MBCOGGKHPPK(T JMDCGOKJIDA, object EOCJCEFCOOA, int CBHPEKJLLAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x47417A0", Offset = "0x473FFA0", VA = "0x1847417A0")]
	public bool NOOCMPIIMHF(object EOCJCEFCOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x473DC90", Offset = "0x473C490", VA = "0x18473DC90")]
	public bool AKPHPFIGELN(object EOCJCEFCOOA, [Out] T JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x4533630", Offset = "0x4531E30", VA = "0x184533630")]
	public void IMJJLGNDCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x473E1A0", Offset = "0x473C9A0", VA = "0x18473E1A0")]
	private bool BCHEJMABEAA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x4741860", Offset = "0x4740060", VA = "0x184741860")]
	public PAOCFNIHNOE()
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
